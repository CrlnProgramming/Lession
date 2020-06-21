using System;

namespace Reminder.Receiver.Telegram
{
    public interface IReminderItemReceiver
    {
        event EventHandler<MessageReceiverEventArgs> MessageReceived;
        void Start();
    }
}
