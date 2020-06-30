namespace Reminder.Sender
{
	public class ReminderNotification
	{
		public string Header { get; }
		public string Text { get; }
		public string ChatId { get; }

		public ReminderNotification(string header, string text, string chatId)
		{
			Header = header;
			Text = text;
			ChatId = chatId;
		}
	}
}