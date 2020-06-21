using System;

namespace Reminder.Storage
{
    public class ReminderItemFilter
    {
        public DateTimeOffset DateTime { get; set; }
        public ReminderItenStatus Status { get; set; }

        public bool IsByDateTime =>
            DateTime != default;

        public bool IsByStatus =>
            Status != default;

        public static ReminderItemFilter All =>
            new ReminderItemFilter(default, default);

        public ReminderItemFilter(ReminderItenStatus status,DateTimeOffset dateTime)
        {
            Status = status;
            DateTime = dateTime;
        }

        public static ReminderItemFilter ByStatus(ReminderItenStatus status) =>
            new ReminderItemFilter(status, default);

        public static ReminderItemFilter ByDateTime(DateTimeOffset dateTime) =>
            new ReminderItemFilter(default, dateTime);

        public static ReminderItemFilter FrowNow() =>
            new ReminderItemFilter(ReminderItenStatus.Created, DateTimeOffset.UtcNow);
    }
}
