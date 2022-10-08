using System;
using System.Collections.Generic;

namespace MigrateEvents.Models
{
    public partial class QuizTrueFalse
    {
        public QuizTrueFalse()
        {
            QuizAnswers = new HashSet<QuizAnswer>();
        }

        public int QuizTrueFalseId { get; set; }
        public string Question { get; set; } = null!;
        public bool? IsTrue { get; set; }
        public int QuizId { get; set; }

        public virtual TrainingQuiz Quiz { get; set; } = null!;
        public virtual ICollection<QuizAnswer> QuizAnswers { get; set; }
    }
}
