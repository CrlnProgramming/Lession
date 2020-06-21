using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using Reminder.Storage;

namespace Reminder.WebApi.ViewModels
{
    public class CreateReminderItemViewModel
    {
        public Guid? Id { get; set; }

        [Required]
        [StringLength(200)]
        public string Title { get; set; }

        [Required]
        [StringLength(4096)]
        public string Message { get; set; }
        [Required]
        public DateTimeOffset? DateTimeUtc { get; set; }

        [Required]
        [StringLength(64)]
        public string UserLogin { get; set; }

        [Required]
        [StringLength(64)]
        public string UserChatId { get; set; }

        public ReminderItenStatus? Status { get; set; }
    }
}
