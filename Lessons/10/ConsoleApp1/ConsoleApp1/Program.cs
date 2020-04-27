using System;


namespace ConsoleApp1
{

    class Program
    {

        static void Main(string[] args)
        {
            Person[] Personal_date = new Person[4];
            
                for (int i = 1; i < Personal_date.Length; i++)
                {
                    Personal_date[i] = new Person();
                    Console.WriteLine($"Write Name {i}: ");
                    Personal_date[i].Name = Console.ReadLine();
                    Console.WriteLine($"Write Age {i}: ");
                    Personal_date[i].Age = Convert.ToInt32(Console.ReadLine());
                    NewMethod(Personal_date, i);
                }
            Console.ReadKey();
        }
        static void NewMethod(Person[] Personal_date, int i)
        {
            Personal_date[i].WriteToConsole();
        }
    }
}



