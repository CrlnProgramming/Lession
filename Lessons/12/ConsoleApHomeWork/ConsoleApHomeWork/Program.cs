using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApHomeWork
{
    class Program
    {
        private const string Errorname = "Input Error";

        static void Main(string[] args)
        {
            Console.WriteLine("Please write current information: \n " +
                            "year, month, day,--- hours, minutes, seconds");
            List<ReminderItem> reminderItems = new List<ReminderItem>();
            


            int year, month, day, hours, minutes, seconds;
            WriteCurrentDate(out year,
                           out month,
                           out day,
                           out hours,
                           out minutes,
                           out seconds);

            DateTime dat = new DateTime(year, month, day, hours, minutes, seconds, DateTimeKind.Utc);

            Console.WriteLine("Write massange");
            string massange = Console.ReadLine();

            Console.WriteLine("Write ur phone number: ");
            string phoneNum = Console.ReadLine();

            Console.WriteLine("Write ur chat name: ");
            string chatN = Console.ReadLine();

            //generation random accauntN
            var rand = new Random();
            string accauntN = rand.Next().ToString();

            
            var phoneRemind = new PhoneReminderItem(dat,massange,phoneNum);
            var chatReminderItem = new ChatReminderItem(dat,massange, chatN, accauntN);
            

            //Older project 
            //var First = new ReminderItem(dat, massange);
            //var Second = new ReminderItem(dat, massange);
            //Console.WriteLine("First progg");
            //First.WriteProperties();
            //Console.WriteLine("Second progg");
            //Second.WriteProperties();
            //Console.ReadKey();

            //new part code
            phoneRemind.WriteProperties();
            chatReminderItem.WriteProperties();

            reminderItems.Add(new ReminderItem(dat,massange) { alarmDate = dat, alarmMessage = massange });
            reminderItems.Add(new PhoneReminderItem(dat, massange, phoneNum) { alarmDate = dat, alarmMessage = massange });
            reminderItems.Add(new ChatReminderItem(dat, massange, chatN, accauntN) { alarmDate = dat, alarmMessage = massange });

            Console.WriteLine();
            foreach (var item in reminderItems)
            {
                item.WriteProperties();
            }
            
            static void WriteCurrentDate(out int year, out int month, out int day, out int hours, out int minutes, out int seconds)
            {
                Console.WriteLine("year");
                year = Int32.Parse(Console.ReadLine());
                Console.WriteLine("month");
                month = Int32.Parse(Console.ReadLine()); 
                if (month > 12)
                {
                    throw new ArgumentOutOfRangeException(Errorname);
                }
                Console.WriteLine("day");
                day = Int32.Parse(Console.ReadLine());
                if (day > 31)
                {
                    throw new ArgumentOutOfRangeException(Errorname);
                }
                Console.WriteLine("------------");
                Console.WriteLine("hours");
                hours = Int32.Parse(Console.ReadLine());
                if (hours > 24)
                {
                    throw new ArgumentOutOfRangeException(Errorname);
                }
                Console.WriteLine("minutes");
                minutes = Int32.Parse(Console.ReadLine());
                if (minutes > 60)
                {
                    throw new ArgumentOutOfRangeException(Errorname);
                }
                Console.WriteLine("seconds");
                seconds = Int32.Parse(Console.ReadLine());
                if (seconds > 60)
                {
                    throw new ArgumentOutOfRangeException(Errorname);
                }
            }
        }
    }
}
