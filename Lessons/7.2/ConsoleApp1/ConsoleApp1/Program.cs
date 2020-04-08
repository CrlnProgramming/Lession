using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите сумму первоначального взноса: ");
            var sum = double.Parse(Console.ReadLine());
            Console.WriteLine("Введите процент первоначального дохода в виде десятичной дроби (1% = 0.01");
            var procent = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите желаемую сумму накопления");
            var SumAccumulation = double.Parse(Console.ReadLine());



            Console.WriteLine("Необходимое количество дней для накопления желаемой сумму: ");
        }
    }
}
