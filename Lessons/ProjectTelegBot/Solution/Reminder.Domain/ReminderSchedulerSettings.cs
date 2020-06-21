using System;
using System.Collections.Generic;
using System.Text;

namespace Reminder.Domain
{
    class ReminderSchedulerSettings
    {
        public TimeSpan ReadyTimerInterval { get; }
        public TimeSpan SenderTimerInterval { get; }

        public ReminderSchedulerSettings(
            TimeSpan readyTimerInterval,
            TimeSpan senderTimerInterval)
        {
            ReadyTimerInterval = readyTimerInterval;
            SenderTimerInterval = senderTimerInterval;
        }
    }
}
