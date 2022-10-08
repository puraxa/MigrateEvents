using System;
using System.Collections.Generic;

namespace MigrateEvents.Models
{
    public partial class TwilioCredential
    {
        public int TwilioCredentialsId { get; set; }
        public string AuthToken { get; set; } = null!;
        public string AccountSid { get; set; } = null!;
        public string PhoneNumber { get; set; } = null!;
        public int InstitutionId { get; set; }

        public virtual Institution Institution { get; set; } = null!;
    }
}
