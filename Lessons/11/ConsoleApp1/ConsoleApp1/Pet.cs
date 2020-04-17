using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class Pet
    {
        public string Kind;
        public string Name;
        public char Sex;
        public DateTimeOffset DateOfBith;

        public string Description => $"Имя: {Kind},Пол: {Sex} ,Количество лет: {Age()}";
        public string ShortDescription => $"Имя: {Kind},Пол: {Age()}";

        public Pet()
        {

        }

       
        public int Age()
        {
            var now = DateTimeKind.Now;
            var diff = now - DateTimeBirth;
            var ages = Math.Floor(diff.TotalDays / 365);
            return (int)ages;
        }

        
    }
}
