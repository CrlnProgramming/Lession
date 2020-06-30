using System;

namespace Reminder.Storage
{
	public class ReminderItemFilter
	{
		public DateTimeOffset DateTime { get; private set; }
		public ReminderItemStatus Status { get; private set; }

		public bool IsByDateTime =>
			DateTime != default;

		public bool IsByStatus =>
			Status != default;

		public static ReminderItemFilter All =>
			new ReminderItemFilter(default, default);

		public ReminderItemFilter(ReminderItemStatus status, DateTimeOffset datetime)
		{
			Status = status;
			DateTime = datetime;
		}

		public static ReminderItemFilter ByStatus(ReminderItemStatus status) =>
			new ReminderItemFilter(status, default);

		public static ReminderItemFilter ByDateTime(DateTimeOffset datetime) =>
			new ReminderItemFilter(default, datetime);

		public static ReminderItemFilter FromNow() =>
			new ReminderItemFilter(ReminderItemStatus.Created, DateTimeOffset.UtcNow);
	}
}