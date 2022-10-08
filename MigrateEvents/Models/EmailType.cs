using System;
using System.Collections.Generic;

namespace MigrateEvents.Models
{
    public partial class EmailType
    {
        public EmailType()
        {
            EmailHeaders = new HashSet<EmailHeader>();
        }

        public int EmailTypeId { get; set; }
        public string TypeName { get; set; } = null!;

        public virtual ICollection<EmailHeader> EmailHeaders { get; set; }
    }
}
