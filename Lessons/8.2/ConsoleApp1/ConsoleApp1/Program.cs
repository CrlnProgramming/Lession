using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] lines)
        {
            while (true)
            {
                try
                {
                    Console.WriteLine("Write string,which need to converted\nDont write empty string ");
                    string str = Console.ReadLine().ToLower();

                    if (str.Length > 0)
                        for (int i = str.Length - 1; i >= 0; i--)
                            Console.WriteLine(str[i]);
                    else
                    {
                        Console.WriteLine("String is empty");
                    }
                    Console.WriteLine("Tap any kay for continuance: ");
                    Console.ReadKey(); Console.WriteLine();
                }

                catch (Exception)
                {
                    Console.WriteLine("Exception er!");
                }
            }
        }
        
    }
}
