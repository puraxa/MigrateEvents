using System;
using System.Collections.Generic;

namespace MigrateEvents.Models
{
    public partial class InstitutionEmail
    {
        public int InstitutionEmailId { get; set; }
        public int EmailHeaderId { get; set; }
        public int InstitutionId { get; set; }
        public string? Subject { get; set; }
        public string? Body { get; set; }

        public virtual EmailHeader EmailHeader { get; set; } = null!;
        public virtual Institution Institution { get; set; } = null!;
    }
}
