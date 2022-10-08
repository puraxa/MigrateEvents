using System;
using System.Collections.Generic;

namespace MigrateEvents.Models
{
    public partial class QuizMultiple
    {
        public QuizMultiple()
        {
            MultipleQuestions = new HashSet<MultipleQuestion>();
            QuizAnswers = new HashSet<QuizAnswer>();
        }

        public int MultipleId { get; set; }
        public string MultipleName { get; set; } = null!;
        public int? CorrectAnswer { get; set; }
        public int? QuizId { get; set; }
        public string? Question { get; set; }

        public virtual MultipleQuestion? CorrectAnswerNavigation { get; set; }
        public virtual TrainingQuiz? Quiz { get; set; }
        public virtual ICollection<MultipleQuestion> MultipleQuestions { get; set; }
        public virtual ICollection<QuizAnswer> QuizAnswers { get; set; }
    }
}
