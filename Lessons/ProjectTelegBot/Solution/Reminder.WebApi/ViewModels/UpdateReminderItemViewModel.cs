using System;
using System.ComponentModel.DataAnnotations;
using Reminder.Storage;

namespace Reminder.WebApi.ViewModels
{
    public class UpdateReminderItemViewModel
    {
        [Required]
        [StringLength(200)]
        public string Title { get; set; }

        [Required]
        [StringLength(4096)]
        public string Message { get; set; }

        [Required]
        public DateTimeOffset? DateTimeUtc { get; set; }

        public ReminderItenStatus Status { get; set; }
    }
}
