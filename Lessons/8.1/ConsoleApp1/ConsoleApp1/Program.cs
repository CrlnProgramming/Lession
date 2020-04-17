using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                var draft = 0; string[] str = { };
                Console.WriteLine();
                Console.WriteLine("Enter a string of several words");


                str = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                if (str.Length > 2)
                {
                    for (int i = 0; i < str.Length; i++)
                    {
                        if (str[i].StartsWith('a'))
                            draft++;
                    }
                    Console.WriteLine("Words with letter 'a': " + draft);
                }
                if (str.Length < 2)
                    Console.WriteLine("Input Error!!!\a");
                if (str.Length == 0)
                    Console.WriteLine("Input Error!!!\nString is empty\a");
            }
            catch (OutOfMemoryException exapt)
            {
                Console.WriteLine("");
                Environment.FailFast(String.Format("Out of Memory: {0}",
                                            exapt.Message));//exception handling and report 

            }
            catch (ArgumentException)
            {
                Console.WriteLine("ArgumentException in String.Insert");
            }

        }
        
                
    }
}
