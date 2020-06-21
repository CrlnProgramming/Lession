using Reminder.Storage;

namespace Reminder.WebApi.ViewModels
{
    public class ReminderItemViewModel
    {
        public string Id { get; set; }
        public string Title { get; set; }
        public string Message { get; set; }
        public string DateTimeUtc { get; set; }
        public string UserLogin { get; set; }
        public string UserChatId { get; set; }
        public string Status { get; set; }

        public ReminderItemViewModel(ReminderItem item)
        {
            Id = item.Id.ToString("N");
            Title = item.Title;
            Message = item.Message;
            DateTimeUtc = item.DateTimeUtc.ToString("O");
            UserLogin = item.User.Login;
            UserChatId = item.User.ChatId;
            Status = item.Status.ToString();
        }
    }
}
