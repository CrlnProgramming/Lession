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
                    
                }

                for (int j = 1; j < Personal_date.Length; j++)
                {
                    Personal_date[j] = new Person();
                    Console.WriteLine($"Write Age {j}: ");
                    Personal_date[j].Age = Convert.ToInt32(Console.ReadLine());
                }

                for (int i = 1; i < Personal_date.Length; i++)
                {
                    Personal_date[i].WriteToConsole();
                }
                Console.ReadKey();
            
            
        }
        
    }
}



