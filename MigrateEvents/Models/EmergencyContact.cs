using System;
using System.Collections.Generic;

namespace MigrateEvents.Models
{
    public partial class EmergencyContact
    {
        public int ContactId { get; set; }
        public int UserId { get; set; }
        public string FirstName { get; set; } = null!;
        public string? MiddleName { get; set; }
        public string LastName { get; set; } = null!;
        public string? Suffix { get; set; }
        public string Address1 { get; set; } = null!;
        public string Address2 { get; set; } = null!;
        public string? Address3 { get; set; }
        public string City { get; set; } = null!;
        public string? StateAbr { get; set; }
        public int CountryId { get; set; }
        public string PrimaryEmail { get; set; } = null!;
        public string SecondaryEmail { get; set; } = null!;
        public string PrimaryPhone { get; set; } = null!;
        public string SecondaryPhone { get; set; } = null!;
        public string EmergencyContactType { get; set; } = null!;
        public bool? Deleted { get; set; }
        public string? Relationship { get; set; }
        public string? Zip { get; set; }

        public virtual Country Country { get; set; } = null!;
        public virtual State? StateAbrNavigation { get; set; }
        public virtual User User { get; set; } = null!;
    }
}
