using System;
using System.Collections.Generic;

namespace MigrateEvents.Models
{
    public partial class VRptTrip
    {
        public int? InstitutionId { get; set; }
        public int TravelAuthId { get; set; }
        public string Name { get; set; } = null!;
        public DateTimeOffset? StartDate { get; set; }
        public DateTimeOffset? EndDate { get; set; }
        public string? Country { get; set; }
        public string Region { get; set; } = null!;
        public string? TripStatus { get; set; }
        public int? TotalTravellers { get; set; }
    }
}
