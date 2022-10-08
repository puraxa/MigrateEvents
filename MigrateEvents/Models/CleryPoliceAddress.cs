using System;
using System.Collections.Generic;

namespace MigrateEvents.Models
{
    public partial class CleryPoliceAddress
    {
        public CleryPoliceAddress()
        {
            CleryReports = new HashSet<CleryReport>();
            GeographyAgencies = new HashSet<GeographyAgency>();
            Lleas = new HashSet<Llea>();
            MissingReportAgencies = new HashSet<MissingReportAgency>();
        }

        public int PoliceId { get; set; }
        public string? PoliceName { get; set; }
        public string? Address { get; set; }
        public string? City { get; set; }
        public string? State { get; set; }
        public string? Zip { get; set; }
        public string? Email { get; set; }
        public int CountryId { get; set; }
        public string? Contact { get; set; }
        public string? Phone { get; set; }
        public string? Fax { get; set; }
        public string? Notes { get; set; }
        public string? Website { get; set; }
        public DateTimeOffset? LastUpdated { get; set; }
        public string? County { get; set; }
        public int Status { get; set; }
        public int? CreatedBy { get; set; }

        public virtual Country Country { get; set; } = null!;
        public virtual User? CreatedByNavigation { get; set; }
        public virtual ICollection<CleryReport> CleryReports { get; set; }
        public virtual ICollection<GeographyAgency> GeographyAgencies { get; set; }
        public virtual ICollection<Llea> Lleas { get; set; }
        public virtual ICollection<MissingReportAgency> MissingReportAgencies { get; set; }
    }
}
