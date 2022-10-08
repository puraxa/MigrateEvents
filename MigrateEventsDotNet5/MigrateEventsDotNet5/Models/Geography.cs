using System;
using System.Collections.Generic;

namespace MigrateEvents.Models
{
    public partial class Geography
    {
        public Geography()
        {
            GeographyAgencies = new HashSet<GeographyAgency>();
            GeographyEffectiveDates = new HashSet<GeographyEffectiveDate>();
            Reports = new HashSet<Report>();
        }

        public int GeographyId { get; set; }
        public string? Name { get; set; }
        public int? CleryGeographicLocationId { get; set; }
        public int? CleryCampusId { get; set; }
        public string? Street { get; set; }
        public string? City { get; set; }
        public string? State { get; set; }
        public string? Zip { get; set; }
        public int? Country { get; set; }
        public string? ControlledSpace { get; set; }
        public string? Distance { get; set; }
        public string? CrossStreets { get; set; }
        public string? BuildingCode { get; set; }
        public string? Notes { get; set; }
        public int? InstitutionId { get; set; }
        public string? GeoAnalysis { get; set; }
        public int? GeographyClassificationId { get; set; }
        public bool? PatrolZone { get; set; }

        public virtual CleryCampus? CleryCampus { get; set; }
        public virtual CleryGeographicLocation? CleryGeographicLocation { get; set; }
        public virtual Country? CountryNavigation { get; set; }
        public virtual GeographyClassification? GeographyClassification { get; set; }
        public virtual Institution? Institution { get; set; }
        public virtual ICollection<GeographyAgency> GeographyAgencies { get; set; }
        public virtual ICollection<GeographyEffectiveDate> GeographyEffectiveDates { get; set; }
        public virtual ICollection<Report> Reports { get; set; }
    }
}
