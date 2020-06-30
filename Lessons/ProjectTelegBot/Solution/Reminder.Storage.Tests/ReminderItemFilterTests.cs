using System;
using NUnit.Framework;

namespace Reminder.Storage.Tests
{
	public class ReminderItemFilterTests
	{
		[Test]
		public void GivenStatus_IsByStatus_ShouldBeTrue()
		{
			Assert.True(ReminderItemFilter.ByStatus(ReminderItemStatus.Ready).IsByStatus);
		}

		[Test]
		public void GivenDateTime_IsByDatetime_ShouldBeTrue()
		{
			Assert.True(ReminderItemFilter.ByDateTime(DateTimeOffset.UtcNow).IsByDateTime);
		}

		[Test]
		public void GivenDateTimeAndStatus_IsByDatetimeAndStatus_ShouldBeTrue()
		{
			var filter = ReminderItemFilter.FromNow();

			Assert.True(filter.IsByStatus);
			Assert.True(filter.IsByDateTime);
		}
	}
}