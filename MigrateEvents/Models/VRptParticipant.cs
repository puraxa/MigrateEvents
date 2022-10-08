using System;
using System.Collections.Generic;

namespace MigrateEvents.Models
{
    public partial class VRptParticipant
    {
        public long? Row { get; set; }
        public int? InstitutionId { get; set; }
        public int? TravelAuthId { get; set; }
        public string TripName { get; set; } = null!;
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public DateTimeOffset Dob { get; set; }
        public string? Gender { get; set; }
        public string? MobilePhone { get; set; }
        public string? PrimaryEmail { get; set; }
        public string PassportNumber { get; set; } = null!;
    }
}
