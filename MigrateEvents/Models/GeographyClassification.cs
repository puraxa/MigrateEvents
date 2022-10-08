using System;
using System.Collections.Generic;

namespace MigrateEvents.Models
{
    public partial class GeographyClassification
    {
        public GeographyClassification()
        {
            Geographies = new HashSet<Geography>();
        }

        public int GeographyClassificationId { get; set; }
        public int InstitutionId { get; set; }
        public string Name { get; set; } = null!;

        public virtual ICollection<Geography> Geographies { get; set; }
    }
}
