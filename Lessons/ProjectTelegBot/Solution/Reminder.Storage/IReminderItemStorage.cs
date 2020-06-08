using System;

namespace Reminder.Storage
{
    public interface IReminderItemStorage
    {
        void Add(ReminderItem item);
        ReminderItem Find(Guid id);
        ReminderItem[] FindByDateTime(DateTimeOffset dateTime);
        void Find(DateTimeOffset dateTime);
        void Delete(Guid id);
        void Update(ReminderItem item);
    }
}
