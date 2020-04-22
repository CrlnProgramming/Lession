using System;
using System.Collections.Generic;

namespace ConsoleApp1
{

    class Program
    {
        var person = new Person();
        static void Main(string[] args)
        {
            var person = new Person
            {
                Name = "Some";
                Age = 12
            };


        }
    }
}



//Console.WriteLine("Введите возраст");
   //         person.Old = Int32.Parse(Console.ReadLine());
       //     person.YearsAfterFour = person.Old + 4;
        //    Console.WriteLine($"Вам,{person.Name} через 4 года будет {person.YearsAfterFour}");