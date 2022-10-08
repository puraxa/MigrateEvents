using System;
using System.Collections.Generic;

namespace MigrateEvents.Models
{
    public partial class EmailHeader
    {
        public EmailHeader()
        {
            InstitutionEmails = new HashSet<InstitutionEmail>();
        }

        public int EmailHeaderId { get; set; }
        public int EmailTypeId { get; set; }
        public string EmailName { get; set; } = null!;

        public virtual EmailType EmailType { get; set; } = null!;
        public virtual ICollection<InstitutionEmail> InstitutionEmails { get; set; }
    }
}
