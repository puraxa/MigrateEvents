using System;
using System.Collections.Generic;

namespace MigrateEvents.Models
{
    public partial class CleryCsaclassification
    {
        public CleryCsaclassification()
        {
            CleryCsausers = new HashSet<CleryCsauser>();
        }

        public int ClassificationId { get; set; }
        public int InstitutionId { get; set; }
        public string Name { get; set; } = null!;

        public virtual ICollection<CleryCsauser> CleryCsausers { get; set; }
    }
}
