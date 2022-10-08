using System;
using System.Collections.Generic;

namespace MigrateEvents.Models
{
    public partial class VRptItinerary
    {
        public int? InstitutionId { get; set; }
        public int TravelAuthId { get; set; }
        public string Name { get; set; } = null!;
        public DateTimeOffset? StartDate { get; set; }
        public DateTimeOffset? EndDate { get; set; }
        public int? ItineraryId { get; set; }
        public string? Country { get; set; }
        public string Region { get; set; } = null!;
        public DateTimeOffset? ItineraryStart { get; set; }
        public DateTimeOffset? ItineraryEnd { get; set; }
        public string? TripStatus { get; set; }
        public int Research { get; set; }
        public int Sabbatical { get; set; }
        public int SiteVisit { get; set; }
        public int Conference { get; set; }
        public int GuestLecture { get; set; }
        public int Meeting { get; set; }
        public int Athletic { get; set; }
        public int Other { get; set; }
        public int Academic { get; set; }
        public int? TotalTravellers { get; set; }
    }
}
