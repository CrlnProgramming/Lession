using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApHomeWork
{
    public class ChatReminderItem : ReminderItem
    {
        private string ChatName;
        private string AccountName;

        public ChatReminderItem(DateTimeOffset alarmDate, string alarmMessage, string chatName,string accountName) : base(alarmDate, alarmMessage)
        {
            ChatName = chatName;
            AccountName = accountName;
        }

        public new void WriteProperties() => Console.WriteLine($"id:{AccountName},{ChatName} write massage {alarmMessage}");

    }
}
