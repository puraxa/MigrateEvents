using System;
using System.Collections.Generic;

namespace MigrateEvents.Models
{
    public partial class Email
    {
        public int MailId { get; set; }
        public int InstitutionId { get; set; }

        public virtual Institution Institution { get; set; } = null!;
    }
}
