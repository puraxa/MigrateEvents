using System;
using System.Collections.Generic;

namespace MigrateEvents.Models
{
    public partial class Disposition
    {
        public int DispositionId { get; set; }
        public int InstitutionId { get; set; }
        public string Name { get; set; } = null!;
        public string ReportType { get; set; } = null!;

        public virtual Institution Institution { get; set; } = null!;
    }
}
