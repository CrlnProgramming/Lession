using System;

namespace Reminder.Storage
{
    public interface IReminderItemStorage
    {
        void Add(ReminderItem item);
        ReminderItem Find(Guid id);
        ReminderItem[] FindByDateTime(DateTimeOffset dateTime) =>FindBy(ReminderItemFilter.ByDateTime(dateTime));
        ReminderItem[] FindBy(ReminderItemFilter filter);

        void Delete(Guid id);
        void Update(ReminderItem item);
    }
}
