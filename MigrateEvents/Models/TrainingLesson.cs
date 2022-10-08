using System;
using System.Collections.Generic;

namespace MigrateEvents.Models
{
    public partial class TrainingLesson
    {
        public TrainingLesson()
        {
            UploadedFiles = new HashSet<UploadedFile>();
        }

        public int LessonId { get; set; }
        public string LessonName { get; set; } = null!;
        public string ContentType { get; set; } = null!;
        public int? LessonOrder { get; set; }
        public int CourseId { get; set; }
        public string? VideoId { get; set; }
        public string? TextualContent { get; set; }
        public int? Timer { get; set; }

        public virtual TrainingCourse Course { get; set; } = null!;
        public virtual ICollection<UploadedFile> UploadedFiles { get; set; }
    }
}
