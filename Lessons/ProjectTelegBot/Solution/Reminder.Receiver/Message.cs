using System;

namespace Reminder.Receiver
{
    public class Message
    {
        public Message(string header, string text, DateTimeOffset dateTimeUtc)
        {
            Header = header;
            Text = text;
            this.dateTimeUtc = dateTimeUtc;
        }
        public string Header { get; }
        public string Text { get; }
        public DateTimeOffset dateTimeUtc { get; }

        public static Message Parse(string text)
        {
            if (string.IsNullOrWhiteSpace(text))
            {
                throw new ArgumentException(nameof(text));
            }

            var part = text.Split(new[] { '\n', ',', ';' }, StringSplitOptions.RemoveEmptyEntries);

            if (part.Length < 3)
            {
                throw new Exception("Erorr!The string contains invalid number of part");
            }
            var title = part[0];
            var result = DateTimeOffset.TryParse(part[1], out var dateTime);
            if (!result)
            {
                throw new ArgumentException("Error!The datetime of string was in invalid format", nameof(text));
            }
            var message = part[2];
            return new Message(title, message, dateTime);
        }
    }
}