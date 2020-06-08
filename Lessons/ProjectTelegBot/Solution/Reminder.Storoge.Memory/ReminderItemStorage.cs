using Reminder.Storage;
using System;
using System.Collections.Generic;

namespace Reminder.Storoge.Memory
{
    public class ReminderItemStorage : IReminderItemStorage
    {
        private Dictionary<Guid, ReminderItem> _items;

        public ReminderItemStorage()
        {
            _items = new Dictionary<Guid, ReminderItem>();
        }
        public void Add(ReminderItem item)
        {
            var key = item.Id;
            _items.Add(key, item);
        }

        public void Delete(Guid id)
        {
            throw new NotImplementedException();
        }

        public ReminderItem Find(Guid id)
        {
            throw new NotImplementedException();
        }

        public void Find(DateTimeOffset dateTime)
        {
            throw new NotImplementedException();
        }

        public ReminderItem[] FindByDateTime(DateTimeOffset dateTime)
        {
            throw new NotImplementedException();
        }

        public void Update(ReminderItem item)
        {
            throw new NotImplementedException();
        }
    }
}
