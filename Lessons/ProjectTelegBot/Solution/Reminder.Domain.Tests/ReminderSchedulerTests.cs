using System;
using System.Net.Http;
using System.Threading;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Logging.Abstractions;
using NUnit.Framework;
using Reminder.Receiver;
using Reminder.Sender;
using Reminder.Storage;
using Reminder.Storage.Memory;

namespace Reminder.Domain.Tests
{

	internal class ReminderItemReceiver : IReminderItemReceiver
	{
		public event EventHandler<MessageReceivedEventArgs> MessageReceived;

		public void Start()
		{
		}
	}

	internal class ReminderItemSender : IReminderItemSender
	{
		public bool ShouldFail;

		public void Send(ReminderNotification notification)
		{
			if (ShouldFail) 
			{
				throw new HttpRequestException("Telegram NE DOSTUPEN");
			}
		}
	}

	public class ReminderSchedulerTests
	{
		private ReminderSchedulerSettings Settings =>
			new ReminderSchedulerSettings(
				TimeSpan.FromMilliseconds(300),
				TimeSpan.FromMilliseconds(500));

		private ReminderItemReceiver Receiver =>
			new ReminderItemReceiver();

		private ILogger<ReminderScheduler> Logger =>
			NullLogger<ReminderScheduler>.Instance;

		private ReminderItemSender SuccessfulSender =>
			new ReminderItemSender() {ShouldFail = false};

		private ReminderItemSender FailedSender =>
			new ReminderItemSender() {ShouldFail = false};

		[Test]
		public void GivenItemWithCreatedStatusAndDatetime_WhenTimersExecutes_ThenStatusChangedToSent()
		{
			// Arrange
			var storage = new ReminderItemStorage(
				CreateReminderItem(datetime: DateTimeOffset.UtcNow.AddMinutes(-1), status: ReminderItemStatus.Created)
			);
			using var scheduler = CreateScheduler(storage, SuccessfulSender);

			// Act
			scheduler.Run();
			WaitTimers();

			// Assert
			var items = storage.FindBy(
				ReminderItemFilter.ByStatus(ReminderItemStatus.Sent)
			);
			Assert.IsNotEmpty(items);
		}

		[Test]
		public void GivenItemWithCreatedStatusAndDatetime_WhenTimersExecutesAndReceiverFailed_ThenStatusChangedToFailed()
		{
			// Arrange
			var storage = new ReminderItemStorage(
				CreateReminderItem(datetime: DateTimeOffset.UtcNow.AddMinutes(-1), status: ReminderItemStatus.Created)
			);
			using var scheduler = CreateScheduler(storage, FailedSender);

			// Act
			scheduler.Run();
			WaitTimers();

			// Assert
			var items = storage.FindBy(
				ReminderItemFilter.ByStatus(ReminderItemStatus.Failed)
			);
			Assert.IsNotEmpty(items);
		}

		private void WaitTimers() => 
			Thread.Sleep(Settings.ReadyTimerInterval + Settings.SendTimerInterval);

		private ReminderScheduler CreateScheduler(
			IReminderItemStorage storage,
			IReminderItemSender sender) =>
			new ReminderScheduler(Logger, storage, Receiver, sender, Settings);

		private static ReminderItem CreateReminderItem(
			DateTimeOffset datetime,
			ReminderItemStatus status) =>
			new ReminderItem(
				Guid.NewGuid(),
				"Title1",
				"Message",
				datetime,
				new User("Username", "1234"),
				status);
	}
}