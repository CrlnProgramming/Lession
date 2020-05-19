using System;
using System.Collections.Generic;
using System.Text;
//using Reminder.Storege;

namespace Reminder.Storage.Memory
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

        public void Delate(Guid id)
        {
            
        }

        public ReminderItem Find(Guid id)
        {
            throw new NotImplementedException();
        }

        public ReminderItem[] FindByDateTime(DateTimeOffset dateTime)
        {
            throw new NotImplementedException();
        }

        public void Update(ReminderItem item)
        {
            
        }
    }
}
