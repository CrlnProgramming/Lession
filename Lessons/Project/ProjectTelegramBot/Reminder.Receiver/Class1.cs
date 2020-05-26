using System;

namespace Reminder.Receiver
{
    public interface IReminderItemReceiver
    {
        event EventHandler<MessageReceivedEventArgs> MessageReceived;
    }

    public class Message
    {
        public string Header { get; set; }
        public string Text { get; set; }
        public DateTimeOffset DateTimeUtc { get; set; }


        public static Message Parce(string text)
        {
            var parts = text.Split(new char[] { '\n' });
            var title = parts[0];
            var datetime = DateTimeOffset.TryParse(parts[1], out var datetiem);
            var
        }
    }
    public class MessageReceivedEventArgs : EventArgs
    {
       public Message Message { get; }
        public string UserID { get; }
    }


    public static class MessageParce
    {

    }

    private void OnMessageReceived(object sender, MessageReceivedEventArgs args)
    {
        var item = new 
    }


}
