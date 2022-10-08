using System;
using System.Collections.Generic;

namespace MigrateEvents.Models
{
    public partial class Dcrclassification
    {
        public int DcrclassificationId { get; set; }
        public int InstitutionId { get; set; }
        public string Name { get; set; } = null!;

        public virtual Institution Institution { get; set; } = null!;
    }
}
