using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Please write current information: \n " +
                "year, month, day,--- hours, minutes, seconds");
            Console.WriteLine("year");
            var year = Int32.Parse(Console.ReadLine());
            Console.WriteLine("month");
            var month = Int32.Parse(Console.ReadLine());
            Console.WriteLine("day");
            var day = Int32.Parse(Console.ReadLine());
            Console.WriteLine("------------");
            Console.WriteLine("hours");
            var hours = Int32.Parse(Console.ReadLine());
            Console.WriteLine("minutes");
            var minutes = Int32.Parse(Console.ReadLine());
            Console.WriteLine("seconds");
            var seconds = Int32.Parse(Console.ReadLine());


            DateTime dat = new DateTime(year, month, day, hours, minutes, seconds, DateTimeKind.Utc);

            Console.WriteLine("Write massange");
            string massange = Console.ReadLine();

            var First = new ReminderItem(dat, massange);
            var Second = new ReminderItem(dat, massange);

            Console.WriteLine("First progg");
            First.WriteProperties();
            Console.WriteLine("Second progg");
            Second.WriteProperties();
            Console.ReadKey();
        }

    }
}
