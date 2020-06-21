using System;
using Telegram.Bot;
using Telegram.Bot.Types;
using Telegram.Bot.Types.Enums;

namespace Reminder.Sender.Telegram
{
    public class ReminderItemSender : IReminderItemSender
    {
        private readonly TelegramBotClient _client;

        public ReminderItemSender(string token)
        {
            _client = new TelegramBotClient(token);
        }
        public void Send(ReminderNotification notification)
        {
            var text = $"{notification.Header}{notification.Text}";
            var chatId = new ChatId(long.Parse(notification.ChatId));

            _client.SendTextMessageAsync(chatId, text)
                .GetAwaiter()
                .GetResult();
        }
    }
}
