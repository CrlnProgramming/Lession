using System;


namespace ConsoleApHomeWork
{
    public class PhoneReminderItem : ReminderItem
    {
        private string PhoneNumber;
        public PhoneReminderItem(DateTimeOffset alarmDate, string alarmMessage, string phoneNumber) : base(alarmDate, alarmMessage) 
            => PhoneNumber = phoneNumber;

        public new void WriteProperties() => Console.WriteLine($"{PhoneNumber} write this alarmMesseng: {alarmMessage} ");
        
    }
}
