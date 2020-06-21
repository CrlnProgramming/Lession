namespace Reminder.Storage
{
    public class User
    {
        public string Login { get; }
        public string ChatId { get; }

        public User(string login, string chatId)
        {
            Login = login;
            ChatId = chatId;
        }
    }
}
