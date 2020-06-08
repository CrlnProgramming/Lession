using NUnit.Framework;

namespace Reminder.Storage.Memory.Tests
{
    public class ReminderItemStorageTests
    {
        [Test]
        public void Test()
        {
            var storage = new ReminderItem();
            storage.Add(null);
        }
    }
}