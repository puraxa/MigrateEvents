using System;
using System.Collections.Generic;

namespace MigrateEvents.Models
{
    public partial class TrainingCourse
    {
        public TrainingCourse()
        {
            CleryCsatrainingAssignments = new HashSet<CleryCsatrainingAssignment>();
            CleryCsauserHistories = new HashSet<CleryCsauserHistory>();
            TrainingLessons = new HashSet<TrainingLesson>();
            TrainingQuizzes = new HashSet<TrainingQuiz>();
        }

        public int CourseId { get; set; }
        public string Name { get; set; } = null!;
        public string? Description { get; set; }
        public DateTimeOffset? StartDate { get; set; }
        public DateTimeOffset? EndDate { get; set; }
        public int InstitutionId { get; set; }
        public int CreatedBy { get; set; }
        public DateTimeOffset CreatedOn { get; set; }
        public bool? Archived { get; set; }
        public int? PassRate { get; set; }

        public virtual User CreatedByNavigation { get; set; } = null!;
        public virtual Institution Institution { get; set; } = null!;
        public virtual ICollection<CleryCsatrainingAssignment> CleryCsatrainingAssignments { get; set; }
        public virtual ICollection<CleryCsauserHistory> CleryCsauserHistories { get; set; }
        public virtual ICollection<TrainingLesson> TrainingLessons { get; set; }
        public virtual ICollection<TrainingQuiz> TrainingQuizzes { get; set; }
    }
}
