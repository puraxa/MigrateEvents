using System;
using System.Collections.Generic;

namespace MigrateEvents.Models
{
    public partial class CleryCsauserHistory
    {
        public int HistoryId { get; set; }
        public int CleryCsauserId { get; set; }
        public string? ActionName { get; set; }
        public DateTimeOffset ActionDate { get; set; }
        public int? ActionId { get; set; }
        public int? TrainingId { get; set; }

        public virtual CleryCsauser CleryCsauser { get; set; } = null!;
        public virtual TrainingCourse? Training { get; set; }
    }
}
