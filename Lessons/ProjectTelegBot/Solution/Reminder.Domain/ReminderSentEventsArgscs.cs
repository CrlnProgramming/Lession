using Reminder.Storage;
using System;
using System.Collections.Generic;
using System.Text;

namespace Reminder.Domain
{
    class ReminderSentEventsArgscs
    {
        public string Message { get; }
        public DateTimeOffset DateTime { get; }

        public ReminderSentEventsArgscs(ReminderItem item)
        {
            Message = item.Message;
            DateTime = item.DateTimeUtc;
        }
    }
}
