using System;


namespace ConsoleApHomeWork
{
     public class ReminderItem
    {
        public DateTimeOffset alarmDate { get; set; }
        public string alarmMessage { get; set; }
        public TimeSpan TimeToAlarm => DateTimeOffset.Now - alarmDate;
        public bool IsOutdated
        {
            get
            {
                TimeSpan V = default;
                if (TimeToAlarm > V)
                    return true;
                else
                    return false;
            }
        }

        public void WriteProperties() => Console.WriteLine($"alarmMessage: {alarmMessage}\nalarmDate {alarmDate}," +
            $"\nTimeToAlarm {TimeToAlarm} \nIsOutdated {IsOutdated}");

        public ReminderItem(DateTimeOffset alarmDate, string alarmMessage)
        {
            this.alarmDate = alarmDate;
            this.alarmMessage = alarmMessage;
        }
    }
}
