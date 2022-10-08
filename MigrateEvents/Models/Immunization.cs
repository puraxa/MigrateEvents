using System;
using System.Collections.Generic;

namespace MigrateEvents.Models
{
    public partial class Immunization
    {
        public int ImmunizationId { get; set; }
        public string Name { get; set; } = null!;
        public DateTimeOffset DateRecieved { get; set; }
        public int MedicalId { get; set; }
        public bool? Deleted { get; set; }

        public virtual Medical Medical { get; set; } = null!;
    }
}
