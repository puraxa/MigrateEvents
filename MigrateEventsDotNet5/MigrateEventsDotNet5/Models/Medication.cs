using System;
using System.Collections.Generic;

namespace MigrateEvents.Models
{
    public partial class Medication
    {
        public int MedicationId { get; set; }
        public string Name { get; set; } = null!;
        public string Dosage { get; set; } = null!;
        public int MedicalId { get; set; }
        public bool? Deleted { get; set; }

        public virtual Medical Medical { get; set; } = null!;
    }
}
