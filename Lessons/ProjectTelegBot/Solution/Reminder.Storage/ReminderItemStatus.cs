namespace Reminder.Storage
{
    public partial class ReminderItem
    {
        public enum ReminderItemStatus
        {
            Undefined = 0,
            Create,
            Ready,
            Sent,
            Failed 
        }
    }
}
