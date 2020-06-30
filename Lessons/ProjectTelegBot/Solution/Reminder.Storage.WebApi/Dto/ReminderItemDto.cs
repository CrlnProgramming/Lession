namespace Reminder.Storage.WebApi.Dto
{
	// DTO
	//   Data
	//   Transfer
	//   Object

	public class ReminderItemDto
	{
		public string Id { get; set; }
		public string Title { get; set; }
		public string Message { get; set; }
		public string DateTimeUtc { get; set; }
		public string UserLogin { get; set; }
		public string UserChatId { get; set; }
		public ReminderItemStatus Status { get; set; }

		public ReminderItemDto()
		{
		}

		public ReminderItemDto(ReminderItem item)
		{
			Id = item.Id.ToString();
			Title = item.Title;
			Message = item.Message;
			DateTimeUtc = item.DateTimeUtc.ToString("O");
			UserLogin = item.User.Login;
			UserChatId = item.User.ChatId;
			Status = item.Status;
		}
	}
}