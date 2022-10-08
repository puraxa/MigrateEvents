using System;
using System.Collections.Generic;

namespace MigrateEvents.Models
{
    public partial class Flight
    {
        public int FlightId { get; set; }
        public int TravelAuthId { get; set; }
        public string Airline { get; set; } = null!;
        public string FlightNumber { get; set; } = null!;
        public string DepartureLocation { get; set; } = null!;
        public DateTimeOffset? DepartureDateTime { get; set; }
        public string ArrivalLocation { get; set; } = null!;
        public bool? Deleted { get; set; }
        public int? UserId { get; set; }

        public virtual TravelAuth TravelAuth { get; set; } = null!;
        public virtual User? User { get; set; }
    }
}
