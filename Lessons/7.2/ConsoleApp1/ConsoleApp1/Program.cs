using System;


namespace ConsoleApp1
{
    class Program
    {
        static void Check(decimal number)
        {
            if (number == 0)
            {
                Console.WriteLine("String is null");
            }
        }
        static void Main(string[] args)
        {
            var argum = false;
            while (!argum)
            {
                try
                {
                    Console.WriteLine("Введите первое значение: ");
                    var sum = Decimal.Parse(Console.ReadLine());
                    Check(sum);

                    Console.WriteLine("Vведите процент первоначального дохода в виде десятичной дроби(1 % = 0.01)");
                    var procent = Decimal.Parse(Console.ReadLine());
                    Check(procent);

                    Console.WriteLine("Введите желаемую сумму накопления ");
                    var SumAccumulation = Decimal.Parse(Console.ReadLine());
                    Check(SumAccumulation);


                    var current = 0M;
                    do
                    {
                        var procedur = procent * sum;
                        current += procedur;
                    }
                    while (SumAccumulation > current);
                    var currentZ = current / 365;
                    var currentM = string.Format("{0:#.##}", currentZ);
                    var C = string.Format("{0:#.##}", current);
                    Console.WriteLine($"Необходимое количество дней для накопления желаемой сумму: {C} дней или за {currentM} лет");
                    Console.WriteLine(); Console.ReadKey();


                }
                catch (FormatException)
                {
                    Console.WriteLine("Ошибка при вводе");
                }

            }
        }


        
    }
}
