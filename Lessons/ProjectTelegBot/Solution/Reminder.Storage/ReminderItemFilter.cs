using System;
using System.Collections.Generic;
using System.Text;

namespace Reminder.Storage
{
    public class ReminderItemFilter
    {
        public DateTimeOffset DateTime { get; set; }
        public ReminderItenStatus Status { get; set; }
        public static ReminderItemFilter ByStatus(ReminderItenStatus status) => new ReminderItemFilter(status);
        public static ReminderItemFilter ByDateTime(DateTimeOffset dateTime) => new ReminderItemFilter(dateTime);
        public static ReminderItemFilter FromNow() => ByDateTime(DateTimeOffset.UtcNow);

        public ReminderItemFilter(DateTimeOffset dateTime)
        {
            DateTime = dateTime;
        }
        public ReminderItemFilter(ReminderItenStatus status)
        {
            Status = status;
        }
    }
}
