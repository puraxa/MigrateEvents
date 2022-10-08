using System;
using System.Collections.Generic;

namespace MigrateEvents.Models
{
    public partial class Rental
    {
        public int RentalId { get; set; }
        public int TravelAuthId { get; set; }
        public string CompanyName { get; set; } = null!;
        public string PhoneNumber { get; set; } = null!;
        public string Address1 { get; set; } = null!;
        public string Address2 { get; set; } = null!;
        public string Address3 { get; set; } = null!;
        public string City { get; set; } = null!;
        public int CountryId { get; set; }
        public DateTimeOffset? PickUpDate { get; set; }
        public DateTimeOffset? DropOffDate { get; set; }
        public bool? Deleted { get; set; }
        public int? UserId { get; set; }
        public string? Email { get; set; }
        public string? Website { get; set; }

        public virtual Country Country { get; set; } = null!;
        public virtual TravelAuth TravelAuth { get; set; } = null!;
        public virtual User? User { get; set; }
    }
}
