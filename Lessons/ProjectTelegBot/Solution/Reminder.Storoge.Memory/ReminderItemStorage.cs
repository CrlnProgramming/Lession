using System;
using System.Collections.Generic;
using System.Linq;

namespace Reminder.Storage.Memory
{
    public class ReminderItemStorage : IReminderItemStorage
    {
        private readonly Dictionary<Guid, ReminderItem> _item;

        public ReminderItemStorage():
            this (Array.Empty<ReminderItem>())
        {
        }
        public ReminderItemStorage(params ReminderItem[] items)
        {
            _item = items.ToDictionary(item => item.Id);
        }

        public void Add(ReminderItem item)
        {
            if(item == null)
            {
                throw new ArgumentNullException(nameof(item));
            }
            if (!_item.TryAdd(item.Id, item))
            {
                throw new ArgumentException(
                    $"Reminder item with title {item.Title} and id {item.Id:N} already exist in storage memory",
                    nameof(item)); 
            }
        }

        public void Delete(Guid id)
        {
            if (id == default)
            {
                throw new ArgumentNullException(nameof(id));
            }

            var result = _item.Remove(id, out _);
            if (!result)
            {
                throw new ArgumentException(
                    $"Reminder with id {id:N} not found in memory storage", nameof(id));
            }
        }

        public ReminderItem Find(Guid id)
        {
            if (id == default)
            {
                throw new ArgumentNullException(nameof(id));
            }

            if (!_item.TryGetValue(id, out var item))
            {
                throw new ArgumentException(
                    $"Reminder with id {id:N} not found", nameof(id));
            }

            return item;
        }

        public ReminderItem[] FindBy(ReminderItemFilter filter)
        {
            var query = _item.Values.AsEnumerable();

            if (filter.IsByStatus)
            {
                query = query.Where(item => item.Status == filter.Status);
            }
            if (filter.IsByDateTime)
            {
                query = query.Where(item => item.DateTimeUtc <= filter.DateTime);
            }
            return query.ToArray();
        }

        public void Update(ReminderItem item)
        {
            if (item == null)
            {
                throw new ArgumentNullException(nameof(item));
            }

            if (!_item.ContainsKey(item.Id))
            {
                throw new ArgumentException(
                    $"Reminder with title {item.Title} and id {item.Id:N} not found in memory storage", nameof(item));
            }

            _item[item.Id] = item;
        }
    }
}
