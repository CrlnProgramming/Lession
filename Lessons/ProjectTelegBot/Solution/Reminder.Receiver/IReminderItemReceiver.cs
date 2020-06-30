using System;

namespace Reminder.Receiver
{
	// Поставить асинхронный таймер, который будет обращаться к Tg и искать в нем события. 

	public interface IReminderItemReceiver
	{
		event EventHandler<MessageReceivedEventArgs> MessageReceived;

		void Start();
	}
}