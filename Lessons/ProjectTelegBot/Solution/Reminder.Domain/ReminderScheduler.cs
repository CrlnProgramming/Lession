using System;
using System.Net.Http;
using System.Threading;
using Microsoft.Extensions.Logging;
using Reminder.Receiver;
using Reminder.Sender;
using Reminder.Storage;

namespace Reminder.Domain
{
	public class ReminderScheduler : IDisposable
	{
		private readonly ILogger _logger;
		private readonly IReminderItemStorage _storage;
		private readonly IReminderItemReceiver _receiver;
		private readonly IReminderItemSender _sender;
		private readonly ReminderSchedulerSettings _settings;
		private Timer _readyTimer;
		private Timer _sendTimer;

		public ReminderScheduler(
			ILogger<ReminderScheduler> logger,
			IReminderItemStorage storage,
			IReminderItemReceiver receiver,
			IReminderItemSender sender,
			ReminderSchedulerSettings settings)
		{
			_logger = logger;
			_storage = storage;
			_receiver = receiver;
			_sender = sender;
			_settings = settings;
		}

		public void Run()
		{
			_logger.LogDebug("Starting receiver component");
			_receiver.MessageReceived += OnMessageReceived;
			_receiver.Start();
			_logger.LogDebug("Started receiver component");

			_logger.LogDebug("Starting timer workers");
			_readyTimer = new Timer(OnReadyTimerTick, null, TimeSpan.Zero, _settings.ReadyTimerInterval);
			_sendTimer = new Timer(OnSenderTimerTick, null, TimeSpan.Zero, _settings.SendTimerInterval);
			_logger.LogDebug("Started timer workers");
		}

		public void Dispose()
		{
			_logger.LogDebug("Stopping receiver component");
			_receiver.MessageReceived -= OnMessageReceived;
			_logger.LogDebug("Stopped receiver component");

			_logger.LogDebug("Stopping timer workers");
			_readyTimer.Dispose();
			_sendTimer.Dispose();
			_logger.LogDebug("Stopped timer workers");
		}

		private void OnReadyTimerTick(object state)
		{
			var items = _storage.FindBy(ReminderItemFilter.FromNow());
			_logger.LogInformation("Found {0} matching items", items.Length);

			foreach (var item in items)
			{
				UpdateStatus(item, ReminderItemStatus.Ready);
			}
		}

		private void OnSenderTimerTick(object state)
		{
			var items = _storage.FindBy(ReminderItemFilter.ByStatus(ReminderItemStatus.Ready));

			foreach (var item in items)
			{
				var notification = new ReminderNotification(
					item.Title,
					item.Message,
					item.User.ChatId);

				try
				{
					_sender.Send(notification);
					UpdateStatus(item, ReminderItemStatus.Sent);
				}
				catch (HttpRequestException exception)
				{
					_logger.LogWarning("Failed to sent item", exception);
					UpdateStatus(item, ReminderItemStatus.Failed);
				}
			}
		}

		private void OnMessageReceived(object sender, MessageReceivedEventArgs args)
		{
			_logger.LogInformation("Received message from: {0}", args.Login);

			var item = new ReminderItem(
				Guid.NewGuid(),
				args.Message.Header,
				args.Message.Text,
				args.Message.DateTimeUtc,
				new User(args.Login, args.ChatId));

			_storage.Add(item);
			_logger.LogInformation("Received message saved in storage with id: {0:N}", item.Id);
		}

		private void UpdateStatus(ReminderItem item, ReminderItemStatus status)
		{
			item.Status = status;
			_storage.Update(item);
			_logger.LogInformation("Item with id: {0:N} changed status to {1}", item.Id, status);
		}
	}
}