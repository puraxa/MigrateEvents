using System;
using System.Collections.Generic;

namespace MigrateEvents.Models
{
    public partial class Alert
    {
        public int AlertId { get; set; }
        public int OwnerId { get; set; }
        public DateTimeOffset DurationStart { get; set; }
        public DateTimeOffset DurationEnd { get; set; }
        public string Subject { get; set; } = null!;
        public string Body { get; set; } = null!;
        public string? Recipients { get; set; }
        public int? InstitutionId { get; set; }

        public virtual Institution? Institution { get; set; }
        public virtual User Owner { get; set; } = null!;
    }
}
