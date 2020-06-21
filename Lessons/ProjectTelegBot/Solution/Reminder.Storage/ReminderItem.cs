using System;

namespace Reminder.Storage
{
    public class ReminderItem
    {
        public string Title { get; set; }
        public string Message { get; set; }
        public User User { get; set; }
        public DateTimeOffset DateTimeUtc { get; set; }
        public Guid Id { get; set; }

        public ReminderItenStatus Status { get; set; }

        public ReminderItem(
            string title,
            string message,
            User user,
            DateTimeOffset dateTimeUtc,
            Guid id,
            ReminderItenStatus status = ReminderItenStatus.Created)
        {
            Title = title;
            Message = message;
            User = user;
            DateTimeUtc = dateTimeUtc;
            Id = id;
            Status = status;
        }
    }
}
