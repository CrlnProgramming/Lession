using System;


namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            var argum = false;
            while (!argum)
            {
                try
                {
                    Console.WriteLine("Введите сумму первоначального взноса: ");
                    var sum = decimal.Parse(Console.ReadLine());
                    if (sum == 0)
                    {
                        throw new Exception("Введенная сумма не должна равняться 0");
                    }
                    Console.WriteLine("Введите процент первоначального дохода в виде десятичной дроби (1% = 0.01)");
                    var procent = decimal.Parse(Console.ReadLine());
                    if (procent == 0)
                    {
                        throw new Exception("Процент не должне равняться 0");
                    }
                    Console.WriteLine("Введите желаемую сумму накопления");
                    var SumAccumulation = decimal.Parse(Console.ReadLine());
                    if (SumAccumulation == 0)
                    {
                        throw new Exception("Желаемая сумма не должна равняться 0");
                    }
                    else
                    {
                        var current = 0M;
                        do
                        {
                            var procedur = procent * sum;
                            current += procedur;
                        }
                        while (SumAccumulation > current);
                        var currentZ = current / 365;
                        var currentM = string.Format("{0:#.##}", currentZ); var C = string.Format("{0:#.##}", current);
                        Console.WriteLine($"Необходимое количество дней для накопления желаемой сумму: {C} дней или за {currentM} лет");
                        Console.WriteLine(); Console.ReadKey();
                    }
                    
                }
                catch (FormatException)
                {
                    Console.WriteLine("Ошибка при вводе.\nCкорее всего вы указали процент накопления через знак '.',a не ','. \nПопробуйте попытку позже.");
                }

            }
        }
    }
}
