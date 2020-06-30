using System;

namespace Reminder.Receiver
{
	public class MessageReceivedEventArgs : EventArgs
	{
		public Message Message { get; }
		public string ChatId { get; }
		public string Login { get; }

		public MessageReceivedEventArgs(Message message, string chatId, string login)
		{
			Message = message;
			ChatId = chatId;
			Login = login;
		}
	}
}