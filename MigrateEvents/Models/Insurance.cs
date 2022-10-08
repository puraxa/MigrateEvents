using System;
using System.Collections.Generic;

namespace MigrateEvents.Models
{
    public partial class Insurance
    {
        public int InsuranceId { get; set; }
        public int UserId { get; set; }
        public string Name { get; set; } = null!;
        public string PolicyNumber { get; set; } = null!;
        public string PhoneNumber { get; set; } = null!;
        public bool? Verification { get; set; }
        public bool? Deleted { get; set; }

        public virtual User User { get; set; } = null!;
    }
}
