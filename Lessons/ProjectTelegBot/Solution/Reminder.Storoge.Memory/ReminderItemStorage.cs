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
            if (item == null) 
            {
                throw new ArgumentNullException(nameof(item));
            }
            if (_items.ContainsKey(item.Id)) 
            {
                throw new ArgumentException(
                    $"Reminder item with title {item.Title} and id {item.Id} already exists in memory storage");
            }
            var key = item.Id;
            _items.Add(key, item);
        }
        public ReminderItem Find(Guid id)
        {
            if (id == null) 
            {
                throw new ArgumentNullException(nameof(id));
            }
            return _items[id];
        }

        public ReminderItem[] FindByDateTime(DateTimeOffset dateTime)
        {
            throw new ArgumentNullException();
        }

        public void Update(ReminderItem item)
        {
            if (item == null) //check for empty object
            {
                throw new ArgumentNullException(nameof(item));
            }
        }
        public void Delete(Guid id)
        {
            if (id == null) 
            {
                throw new ArgumentNullException(nameof(id));
            }
            _items.Remove(id);
        }

        public ReminderItem[] FindBy(ReminderItemFilter filter)
        {
            throw new NotImplementedException();
        }
    }
}
