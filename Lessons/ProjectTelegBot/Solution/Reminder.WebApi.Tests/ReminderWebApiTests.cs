using System;
using System.Linq;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc.Testing;
using Microsoft.AspNetCore.TestHost;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.DependencyInjection.Extensions;
using NUnit.Framework;
using Reminder.Storage;
using Reminder.Storage.WebApi;
using MemoryReminderItemStorage = Reminder.Storage.Memory.ReminderItemStorage;

namespace Reminder.WebApi.Tests
{
	class ReminderWebAplicationFactory : WebApplicationFactory<Startup>
    {
		private ReminderItem[] _existingItems;
		public ReminderItemStorage CreateReminderStorage()
			=> new ReminderItemStorage(CreateClient());
        protected override void ConfigureWebHost(IWebHostBuilder builder)
        {
            builder.ConfigureTestServices(services =>
            {
                var descriptor = ServiceDescriptor.Singleton<IReminderItemStorage>
                    (provider => new MemoryReminderItemStorage(_existingItems)
                    );
                services.Replace(descriptor);
            }
            );
            base.ConfigureWebHost(builder);
        }
		public ReminderWebAplicationFactory WithItems(params ReminderItem[] items)
        {
			_existingItems = items;
			return this;
        }
    }
	public class ReminderWebApiTests
	{
		[Test]
		public void WhenReminderCreated_ShouldReturnById()
		{
			var item = new ReminderItem(
				Guid.NewGuid(),
				"Title",
				"message",
				DateTimeOffset.UtcNow,
				new User("Cli", "Chat")
			);

			var storage = new ReminderWebAplicationFactory()
				.WithItems(item)
				.CreateReminderStorage();

			storage.Add(item);

			var result = storage.Find(item.Id);
			Assert.AreEqual(item.Title, result.Title);
		}
		
	}
}