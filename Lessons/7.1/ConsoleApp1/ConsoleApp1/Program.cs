using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            var text = false;
            do
            {
                try
                {
                    Console.WriteLine("Введите число: ");
                    var ch = int.Parse(Console.ReadLine()); var sum = 0; var sum1 = 0;
                    Console.WriteLine();
                    for (int i = 0; i <= ch; i++)
                    {
                        if (i % 2 == 0)
                        {
                            Console.WriteLine("{0} ", i);
                        }
                    }
                    Console.WriteLine();
                    for (int j = 1; j < ch; j += 2)
                    {
                        sum1 += j;
                        sum++;
                    }
                    Console.WriteLine($"Quantity of even numbers: {sum}");
                    Console.WriteLine($"Sum of even numbers: {sum1}");
                    if (ch < 0)
                    {
                        Console.WriteLine("Error!");
                    }
                    Console.ReadKey();
                }

                catch (FormatException e)
                {
                    Console.WriteLine("Format Exception");
                }
                catch (OverflowException )
                {
                    Console.WriteLine("Overflow Exception");
                }
                
            } while (!text);
        }
    }
}
