using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Reminder.Storage;
using Reminder.WebApi.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace Reminder.WebApi.Controllers
{
	public class ReminderControlers : ControllerBase
	{
		private readonly IReminderItemStorage _storage;
		public ReminderControlers(IReminderItemStorage storage)
		{
			_storage = storage;
		}

		[HttpGet]
		public IActionResult List(ReminderItenStatus status, DateTimeOffset datetimeUtc)
		{
			var items = _storage.FindBy(
				new ReminderItemFilter(status, datetimeUtc)
			);
			var result = items
				.OrderBy(_ => _.DateTimeUtc)
				.Select(item => new ReminderItemViewModel(item));
			return Ok(result);
		}

		[HttpGet("{id}")]
		public IActionResult Get(Guid id)
		{
			try
			{
				var item = _storage.Find(id);
				return Ok(new ReminderItemViewModel(item));
			}
			catch (ArgumentNullException)
			{
				return BadRequest();
			}
			catch (ArgumentException)
			{
				return NotFound();
			}
		}

		[HttpPost]
		public IActionResult Create([FromBody] CreateReminderItemViewModel model)
		{
			if (!ModelState.IsValid)
			{
				return BadRequest(ModelState);
			}

			var item = new ReminderItem(
				model.Id?? Guid.NewGuid(),
				model.Title,
				model.Message,
				model.DateTimeUtc.GetValueOrDefault(),
				new User(
					model.UserLogin,
					model.UserChatId),
				model.Status ?? ReminderItenStatus.Created
			);
			try
			{
				_storage.Add(item);
				return Ok(new ReminderItemViewModel(item));
			}
			catch (ArgumentException)
			{
				return Conflict();
			}
		}

		[HttpPut("{id}")]
		public IActionResult Update(Guid id, [FromBody] UpdateReminderItemViewModel model)
		{
			if (!ModelState.IsValid)
			{
				return BadRequest(ModelState);
			}

			try
			{
				var target = _storage.Find(id);
				var item = new ReminderItem(
					target.Id,
					model.Title,
					model.Message,
					model.DateTimeUtc.GetValueOrDefault(),
					target.User,
					model.Status);
				_storage.Update(item);

				return Ok(new ReminderItemViewModel(item));
			}
			catch (ArgumentNullException)
			{
				return BadRequest();
			}
			catch (ArgumentException)
			{
				return NotFound();
			}
		}
		[HttpDelete("{id}")]
		public IActionResult Delete(Guid id)
		{
			try
			{
				_storage.Delete(id);
				return NoContent();
			}
			catch (ArgumentNullException)
			{
				return BadRequest();
			}
			catch (ArgumentException)
			{
				return NotFound();
			}
		}
	}
}
