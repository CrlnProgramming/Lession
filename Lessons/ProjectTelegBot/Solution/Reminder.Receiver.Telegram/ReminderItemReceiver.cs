using System;
using Telegram.Bot;
using Telegram.Bot.Args;

namespace Reminder.Receiver.Telegram
{
    public class ReminderItemReceiver : IReminderItemReceiver
    {
        public event EventHandler<MessageReceiverEventArgs> MessageReceived;

        private readonly TelegramBotClient _client;

        public ReminderItemReceiver(string token)
        {
            _client = new TelegramBotClient(token);
        }
        public void Start()
        {
            _client.OnMessage += OnMessage;
            _client.StartReceiving();
        }

        private void OnMessage(object sender, MessageEventArgs args)
        {
            try
            {
                var message = Message.Parse(args.Message.Text);
                var chat = args.Message.Chat;
                var eventArgs = new MessageReceiverEventArgs(
                    message,
                    chat.Id.ToString(),
                    chat.Username);
                OnMessageReceived(eventArgs);
            }
            catch(ArgumentException)
            {
                // Fail massage 
            }
        }

        private void OnMessageReceived(MessageReceiverEventArgs args)
        {
            MessageReceived?.Invoke(this, args);
        }
    }
}
