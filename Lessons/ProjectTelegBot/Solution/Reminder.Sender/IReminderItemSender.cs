using System;

namespace Reminder.Sender
{
	public interface IReminderItemSender
	{
		void Send(ReminderNotification notification);
	}
}