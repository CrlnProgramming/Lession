using System;
using Microsoft.Extensions.Logging;
using Reminder.Domain;
using Reminder.Receiver.Telegram;
using Reminder.Sender.Telegram;
using Reminder.Storage.Memory;

namespace Reminder
{
	class Program
	{
		static void Main()
		{
			const string token = "579816050:AAEUKVMwEzwg1zgHnMH4q4rn3pjNu4Dovus";

			using var factory = LoggerFactory.Create(_ => _.AddConsole());
			using var scheduler = new ReminderScheduler(
				factory.CreateLogger<ReminderScheduler>(),
				new ReminderItemStorage(),
				new ReminderItemReceiver(token),
				new ReminderItemSender(token),
				new ReminderSchedulerSettings(
					readyTimerInterval: TimeSpan.FromSeconds(3),
					sendTimerInterval: TimeSpan.FromSeconds(5))
			);
			scheduler.Run();
			Console.ReadKey();
		}
	}
}