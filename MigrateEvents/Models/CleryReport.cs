using System;
using System.Collections.Generic;

namespace MigrateEvents.Models
{
    public partial class CleryReport
    {
        public int CleryId { get; set; }
        public DateTimeOffset? ArrivalDate { get; set; }
        public DateTimeOffset? DepartureDate { get; set; }
        public string? LocationName { get; set; }
        public string? LocationRoomNum { get; set; }
        public string? LocationStreetAddress { get; set; }
        public string? LocationCity { get; set; }
        public string? LocationState { get; set; }
        public string? LocationZip { get; set; }
        public string? ContactName { get; set; }
        public string? ContactEmail { get; set; }
        public string? ContactPhone { get; set; }
        public int? PoliceAddressId { get; set; }
        public string? PoliceNotes { get; set; }
        public int? LocationCountryId { get; set; }
        public string? LocationNotes { get; set; }
        public int? ContactUnitId { get; set; }
        public int? ContactSubUnitId { get; set; }
        public int? RelatedTripId { get; set; }
        public string? LocationEmail { get; set; }
        public string? LocationPhone { get; set; }
        public bool? Archived { get; set; }
        public int? InstitutionId { get; set; }
        public string? Status { get; set; }
        public string? CaseNumber { get; set; }
        public int? CleryCampusId { get; set; }
        public int? LocationId { get; set; }

        public virtual CleryCampus? CleryCampus { get; set; }
        public virtual InstitutionDepartment? ContactSubUnit { get; set; }
        public virtual InstitutionCollegeSchool? ContactUnit { get; set; }
        public virtual CleryGeographicLocation? Location { get; set; }
        public virtual Country? LocationCountry { get; set; }
        public virtual CleryPoliceAddress? PoliceAddress { get; set; }
        public virtual TravelAuth? RelatedTrip { get; set; }
    }
}
