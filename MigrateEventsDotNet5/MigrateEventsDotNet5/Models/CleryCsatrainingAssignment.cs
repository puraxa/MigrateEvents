using System;
using System.Collections.Generic;

namespace MigrateEvents.Models
{
    public partial class CleryCsatrainingAssignment
    {
        public int AssignmentId { get; set; }
        public int CourseId { get; set; }
        public int CleryCsaid { get; set; }
        public DateTimeOffset DateAssigned { get; set; }
        public DateTimeOffset? DateCompleted { get; set; }
        public int? PercentEarned { get; set; }

        public virtual CleryCsauser CleryCsa { get; set; } = null!;
        public virtual TrainingCourse Course { get; set; } = null!;
    }
}
