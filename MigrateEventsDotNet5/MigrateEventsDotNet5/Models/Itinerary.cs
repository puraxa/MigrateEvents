using System;
using System.Collections.Generic;

namespace MigrateEvents.Models
{
    public partial class Itinerary
    {
        public int ItineraryId { get; set; }
        public int TravelAuthId { get; set; }
        public string City { get; set; } = null!;
        public string Region { get; set; } = null!;
        public int CountryId { get; set; }
        public DateTimeOffset StartDate { get; set; }
        public DateTimeOffset EndDate { get; set; }
        public string Purpose { get; set; } = null!;
        public string Companions { get; set; } = null!;
        public bool? Deleted { get; set; }
        public int? UserId { get; set; }
        public string? AccName { get; set; }
        public string? AccAddress { get; set; }
        public string? AccPostcode { get; set; }
        public string? AccPhone { get; set; }
        public string? AccEmail { get; set; }
        public string? AccWebsite { get; set; }
        public string? AccRoomNum { get; set; }

        public virtual Country Country { get; set; } = null!;
        public virtual TravelAuth TravelAuth { get; set; } = null!;
        public virtual User? User { get; set; }
    }
}
