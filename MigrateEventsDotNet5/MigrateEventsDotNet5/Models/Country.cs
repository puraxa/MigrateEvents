using System;
using System.Collections.Generic;

namespace MigrateEvents.Models
{
    public partial class Country
    {
        public Country()
        {
            CleryPoliceAddresses = new HashSet<CleryPoliceAddress>();
            CleryReports = new HashSet<CleryReport>();
            EmergencyContacts = new HashSet<EmergencyContact>();
            Geographies = new HashSet<Geography>();
            Institutions = new HashSet<Institution>();
            Itineraries = new HashSet<Itinerary>();
            PassportCitizenshipNavigations = new HashSet<Passport>();
            PassportIssuedByNavigations = new HashSet<Passport>();
            Rentals = new HashSet<Rental>();
            RiskCountries = new HashSet<RiskCountry>();
        }

        public int CountryId { get; set; }
        public string Name { get; set; } = null!;
        public int? RegionId { get; set; }

        public virtual Region? Region { get; set; }
        public virtual ICollection<CleryPoliceAddress> CleryPoliceAddresses { get; set; }
        public virtual ICollection<CleryReport> CleryReports { get; set; }
        public virtual ICollection<EmergencyContact> EmergencyContacts { get; set; }
        public virtual ICollection<Geography> Geographies { get; set; }
        public virtual ICollection<Institution> Institutions { get; set; }
        public virtual ICollection<Itinerary> Itineraries { get; set; }
        public virtual ICollection<Passport> PassportCitizenshipNavigations { get; set; }
        public virtual ICollection<Passport> PassportIssuedByNavigations { get; set; }
        public virtual ICollection<Rental> Rentals { get; set; }
        public virtual ICollection<RiskCountry> RiskCountries { get; set; }
    }
}
