using System;
using System.Collections.Generic;

namespace MigrateEvents.Models
{
    public partial class CleryCampus
    {
        public CleryCampus()
        {
            CleryReports = new HashSet<CleryReport>();
            CrimeLogArchives = new HashSet<CrimeLogArchive>();
            DailyCrimeLogs = new HashSet<DailyCrimeLog>();
            Geographies = new HashSet<Geography>();
            GeographyMaps = new HashSet<GeographyMap>();
        }

        public int CleryCampusId { get; set; }
        public string Name { get; set; } = null!;
        public int InstitutionId { get; set; }

        public virtual Institution Institution { get; set; } = null!;
        public virtual ICollection<CleryReport> CleryReports { get; set; }
        public virtual ICollection<CrimeLogArchive> CrimeLogArchives { get; set; }
        public virtual ICollection<DailyCrimeLog> DailyCrimeLogs { get; set; }
        public virtual ICollection<Geography> Geographies { get; set; }
        public virtual ICollection<GeographyMap> GeographyMaps { get; set; }
    }
}
