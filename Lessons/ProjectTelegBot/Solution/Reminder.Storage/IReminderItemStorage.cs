using System;

namespace Reminder.Storage
{
    public interface IReminderItemStorage
    {
        void Add(ReminderItem item);
        ReminderItem Find(Guid id);
        ReminderItem[] FindBy(ReminderItemFilter filter); 
        void Delete(Guid id);
        void Update(ReminderItem item);
    }
}
