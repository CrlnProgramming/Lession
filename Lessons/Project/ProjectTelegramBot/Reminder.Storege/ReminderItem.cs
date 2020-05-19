using System;

namespace Reminder.Storage
{
    public class ReminderItem
    {
        public Guid Id { get; set; }
        public string Message { get; set; }
        public string Tittel { get; set; }
        public DateTimeOffset DateTime { get; set; }
        public string UserId { get; set; }
        public ReminderItemStatus State { get; set; }

        public ReminderItem(
            Guid id, 
            string message, 
            string tittel, 
            DateTimeOffset dateTime, 
            string userId,
            ReminderItemStatus state = ReminderItemStatus.Created)
        {
            Id = id;
            Message = message;
            Tittel = tittel;
            DateTime = dateTime;
            UserId = userId;
        }
        

    }
}

