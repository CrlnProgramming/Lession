using System;

namespace Reminder.Receiver.Telegram
{
    public class MessageReceiverEventArgs : EventArgs
    {
        public Message Message { get; }
        public string ChatId { get; }
        public string Login { get; }
        public MessageReceiverEventArgs(Message message, string chatId, string login)
        {
            Message = message;
            ChatId = chatId;
            Login = login;
        }
    }
}
