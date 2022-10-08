using System;
using System.Collections.Generic;

namespace MigrateEvents.Models
{
    public partial class VRptStep
    {
        public int? InstitutionId { get; set; }
        public int? TravelAuthId { get; set; }
        public string TripName { get; set; } = null!;
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public string? PrimaryPhone { get; set; }
        public string? PrimaryEmail { get; set; }
        public DateTimeOffset Dob { get; set; }
        public string PassportNumber { get; set; } = null!;
        public DateTimeOffset IssuedOn { get; set; }
    }
}
