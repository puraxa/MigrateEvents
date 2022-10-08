using System;
using System.Collections.Generic;

namespace MigrateEvents.Models
{
    public partial class TrainingQuiz
    {
        public TrainingQuiz()
        {
            QuizMultiples = new HashSet<QuizMultiple>();
            QuizTrueFalses = new HashSet<QuizTrueFalse>();
        }

        public int QuizId { get; set; }
        public string QuizType { get; set; } = null!;
        public int CourseId { get; set; }
        public string? QuizName { get; set; }
        public int? QuestionOrder { get; set; }

        public virtual TrainingCourse Course { get; set; } = null!;
        public virtual ICollection<QuizMultiple> QuizMultiples { get; set; }
        public virtual ICollection<QuizTrueFalse> QuizTrueFalses { get; set; }
    }
}
