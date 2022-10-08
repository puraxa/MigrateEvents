using System;
using System.Collections.Generic;

namespace MigrateEvents.Models
{
    public partial class Message
    {
        public int MessageId { get; set; }
        public string MessageType { get; set; } = null!;
        public string? MessageText { get; set; }
        public string? Subject { get; set; }
        public int SenderId { get; set; }
        public int RecepientId { get; set; }
        public int? OriginalMessageId { get; set; }
        public bool? HasRead { get; set; }
        public DateTimeOffset Daterecieved { get; set; }
        public DateTimeOffset? DateStart { get; set; }
        public DateTimeOffset? DateEnd { get; set; }

        public virtual User Recepient { get; set; } = null!;
        public virtual User Sender { get; set; } = null!;
    }
}
