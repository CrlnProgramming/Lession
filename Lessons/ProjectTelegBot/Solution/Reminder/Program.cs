using System;
using Reminder.Domain;
using Reminder.Receiver.Telegram;
using Reminder.Sender.Telegram;
using Reminder.Storage.Memory;
using Microsoft.Extensions.Logging;

namespace Reminder
{
    class Program
    {
        static void Main()
        {
            const string token = "612381361:AAF3EbHO5MIRrxO54l6MyKXglABYCFp7MDE";//--------
            using var factory = LoggerFactory.Create(_ => _.AddConsole());
            using var scheduler = new RerminderScheduler(
                factory.CreateLogger<RerminderScheduler>(),
                new ReminderItemStorage(),
                new ReminderItemReceiver(token),
                new ReminderItemSender(token),
                new RerminderSchedulerSettings(
                    readyTimerInterval: TimeSpan.FromSeconds(3),
                    sendTimerInterval: TimeSpan.FromSeconds(5))
                    );
            scheduler.Run();
            Console.ReadKey();
        }
    }
}
