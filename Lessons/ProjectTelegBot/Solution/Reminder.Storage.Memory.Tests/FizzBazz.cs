using NUnit.Framework;
using System;

namespace Reminder.Storage.Memory.Tests
{
    public class Logic
    {
        public string FizzBuzz(int number)
            {
            if (number % 3 == 0 && number % 5 == 0)
            {
                return "FizzBazz";
            }
            if (number %3 == 0)
            {
                return "Fizz";
            }
            if(number %5 == 0)
            {
                return "Bazz";
            }
            return number.ToString();
            }
    }
    public class Tests
    {
        private Logic _logic;

        [SetUp]
        public void Setup()
        {
            _logic = new Logic();
        }

        [Test]
        [TestCase(1)]
        [TestCase(7)]
        [TestCase(42)]
        public void WhenNumberDivideBy1_ThenResultWillBe1(int number)
        {
            var result = _logic.FizzBuzz(number);
            Assert.AreEqual(number.ToString(), result);
        }
        [Test]
        public void WhenNumberDivideBy3_ThenResultWillBeFizz()
        {  
            var result = _logic.FizzBuzz(3);
            Assert.AreEqual("Fizz", result);
        }
        [Test]
        public void WhenNumberDivideBy5_ThenResultWillBeBazz()
        {
            var result = _logic.FizzBuzz(5);
            Assert.AreEqual("Bazz", result);
        }
        [Test]
        public void WhenNumberDivideBy3And5_ThenResultWillBeFizzBazz()
        {
            var result = _logic.FizzBuzz(45);
            Assert.AreEqual("FizzBazz", result);
        }
    }

}