using System;
using System.Collections.Generic;

namespace MigrateEvents.Models
{
    public partial class CleryGeographicLocation
    {
        public CleryGeographicLocation()
        {
            CleryReports = new HashSet<CleryReport>();
            Geographies = new HashSet<Geography>();
        }

        public int LocationId { get; set; }
        public string Name { get; set; } = null!;

        public virtual ICollection<CleryReport> CleryReports { get; set; }
        public virtual ICollection<Geography> Geographies { get; set; }
    }
}
