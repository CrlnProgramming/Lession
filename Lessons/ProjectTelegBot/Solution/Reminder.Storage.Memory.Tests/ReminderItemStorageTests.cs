using System;
using NUnit.Framework;

namespace Reminder.Storage.Memory.Tests
{
	public class ReminderItemStorageTests
	{
		[Test]
		public void WhenItemIsNull_ThenThrowsArgumentNullException()
		{
			var storage = new ReminderItemStorage();

			Assert.Catch<ArgumentNullException>(() =>
				storage.Add(null)
			);
		}

		[Test]
		public void WhenItemNotExists_ThenCanFindById()
		{
			var storage = new ReminderItemStorage();
			var item = CreateReminderItem();

			storage.Add(item);
			var result = storage.Find(item.Id);

			Assert.NotNull(result);
			Assert.AreEqual(item.Id, result.Id);
			Assert.AreEqual(item.Message, result.Message);
		}

		[Test]
		public void WhenItemExists_ThenThrowsArgumentException()
		{
			var item = CreateReminderItem();
			var storage = new ReminderItemStorage(item);

			var exception = Assert.Catch<ArgumentException>(() =>
				storage.Add(item)
			);
			Assert.IsTrue(exception.Message.Contains(item.Title));
		}

		[Test]
		public void ShouldThrowArgumentNullException_WhenUpdateItemIsNull()
		{
			var storage = new ReminderItemStorage();

			Assert.Catch<ArgumentNullException>(() =>
				storage.Update(null)
			);
		}

		[Test]
		public void ShouldThrowArgumentException_WhenUpdateItemNotExists()
		{
			var storage = new ReminderItemStorage();
			var id = Guid.NewGuid();

			var exception = Assert.Catch<ArgumentException>(() =>
				storage.Update(
					CreateReminderItem(id)
				)
			);
			Assert.IsTrue(exception.Message.Contains(id.ToString("N")));
		}

		[Test]
		public void ShouldSaveUpdatedItem_WhenItemExists()
		{
			var item = CreateReminderItem();
			var storage = new ReminderItemStorage(item);

			item.Message = "Another message";
			storage.Update(item);

			var result = storage.Find(item.Id);
			Assert.AreEqual("Another message", result.Message);
		}

		[Test]
		public void GivenItemNotExists_WhenFind_ThenThrowArgumentException()
		{
			var storage = new ReminderItemStorage();
			var id = Guid.NewGuid();

			var exception = Assert.Catch<ArgumentException>(() =>
				storage.Find(id)
			);
			StringAssert.Contains(id.ToString("N"), exception.Message);
		}

		[Test]
		public void GivenItemExists_WhenFind_ThenShouldReturnIt()
		{
			var item = CreateReminderItem();
			var storage = new ReminderItemStorage(item);

			var result = storage.Find(item.Id);

			Assert.AreEqual(item.Id, result.Id);
			Assert.AreEqual(item.Title, result.Title);
			Assert.AreEqual(item.Message, result.Message);
		}

		[Test]
		public void GivenCreatedItems_WhenFindByReadyStatus_ShouldReturnEmpty()
		{
			var storage = new ReminderItemStorage(
				CreateReminderItem(datetime: DateTimeOffset.UtcNow, status: ReminderItenStatus.Created),
				CreateReminderItem(datetime: DateTimeOffset.UtcNow.AddMinutes(-1), status: ReminderItenStatus.Created));

			var result = storage.FindBy(
				ReminderItemFilter.ByStatus(ReminderItenStatus.Ready)
			);

			Assert.IsEmpty(result);
		}

		[Test]
		public void GivenReadyItems_WhenFindByReadyStatus_ShouldReturnElements()
		{
			var storage = new ReminderItemStorage(
				CreateReminderItem(datetime: DateTimeOffset.UtcNow.AddMinutes(-1), status: ReminderItenStatus.Ready));

			var result = storage.FindBy(
				ReminderItenStatus.ByStatus(ReminderItenStatus.Ready)
			);

			Assert.IsNotEmpty(result);
		}

		[Test]
		public void GivenCreatedItems_WhenFindFromNow_ShouldReturnMatchingElements()
		{
			var storage = new ReminderItemStorage(
				CreateReminderItem(datetime: DateTimeOffset.UtcNow.AddSeconds(20), status: ReminderItenStatus.Created),
				CreateReminderItem(datetime: DateTimeOffset.UtcNow.AddMinutes(-1), status: ReminderItenStatus.Created),
				CreateReminderItem(datetime: DateTimeOffset.UtcNow.AddMinutes(1), status: ReminderItenStatus.Created)
			);

			var result = storage.FindBy(ReminderItemFilter.FrowNow());

			Assert.IsNotEmpty(result);
			Assert.AreEqual(1, result.Length);
		}

		private ReminderItem CreateReminderItem(
			Guid? id = default,
			string title = default,
			string message = default,
			DateTimeOffset? datetime = default,
			ReminderItenStatus? status = default)
		{
			return new ReminderItem(
				id ?? Guid.NewGuid(),
				title ?? "Title",
				message ?? "Message",
				datetime ?? DateTimeOffset.UtcNow,
				new User("Login", "ChatId"),
				status ?? ReminderItenStatus.Created);
		}
	}
}