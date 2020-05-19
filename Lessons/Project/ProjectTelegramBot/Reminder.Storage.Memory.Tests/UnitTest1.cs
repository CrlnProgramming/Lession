using NUnit.Framework;
using System;

namespace Reminder.Storage.Memory.Tests
{
    public class Tests
    {
        public class Logic
        {
            //Fiz -> /3
            //Bazz -> /5
            //FizzBazz -> /15
            //return string 
            [Test]
            [TestCase]
            public string WhenNumberEquals1_ThenResultWillbe1(int number)
            {
                if (number % 3 == 0 && number % 5 == 0)
                {
                    return "FizzBazz";
                }
                if (number %3 == 0)
                {
                    return "Fizz";
                }
                if (number % 5 == 0)
                {
                    return "Bazz";
                }
                return number.ToString();
            }
        }
        [Test]
        public void WhenNumberIsOne()
        {
            var logic = new Logic();
            var result = logic.WhenNumberEquals1_ThenResultWillbe1(1);
            Assert.AreEqual("1", result);
        }
        public void WhenNumberDivideBy3_ThenResultWillBeFizz()
        {
            var logic = new Logic();
            var result = logic.WhenNumberEquals1_ThenResultWillbe1(3);
            Assert.AreEqual("Fizz", result);
        }
        public void WhenNumberDivideBy5_ThenResultWillBeBazz()
        {
            var logic = new Logic();
            var result = logic.WhenNumberEquals1_ThenResultWillbe1(5);
            Assert.AreEqual("Bazz", result);
        }
        public void WhenNumberDivideBy3and5_ThenResultWillBeFizz()
        {
            var logic = new Logic();
            var result = logic.WhenNumberEquals1_ThenResultWillbe1(45);
            Assert.AreEqual("FizzBazz", result);
        }

        
    }

    public class ReminderItemStorageTests
    {
        [Test]
        public void WhenItemIsNull_ThenTrowsArgumentNullExcaption(ReminderItem item)
        {

            var storage = new ReminderItemStorage();
            storage.Add(null);
            Assert.Catch<ArgumentNullException>(() => storage.Add(null));
        }
        public void WhenItemNotExists_thenCanFindById()
        {
            var storage = new ReminderItemStorage();
            var item = new ReminderItem(Guid.NewGuid(),
                "Header",
                "Message",
                DateTimeOffset.Now,
                "UserId");

            storage.Add(item);
        }

        public void Add(ReminderItem item)
        {
            if (item == null)
            {
                throw new ArgumentNullException(nameof(item));
            }

            if (_items.ContainsKey(item.Id))
            {
                throw new 
            }
        }
        public ReminderItem 
        public void WhenItemExist()
        {
            var storage = new ReminderItemStorage();
            var item = new ReminderItem(Guid.NewGuid(),
                "Header",
                "Message",
                DateTimeOffset.Now,
                "UserId");

            storage.Add(item);

            var eception = Assert.Catch<ArgumentException>(())
        }
    }
}