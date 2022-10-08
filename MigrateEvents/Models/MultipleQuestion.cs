using System;
using System.Collections.Generic;

namespace MigrateEvents.Models
{
    public partial class MultipleQuestion
    {
        public MultipleQuestion()
        {
            QuizAnswers = new HashSet<QuizAnswer>();
            QuizMultiples = new HashSet<QuizMultiple>();
        }

        public int MultipleQuestionId { get; set; }
        public string Question { get; set; } = null!;
        public int MultipleId { get; set; }
        public int? QuestionOrder { get; set; }

        public virtual QuizMultiple Multiple { get; set; } = null!;
        public virtual ICollection<QuizAnswer> QuizAnswers { get; set; }
        public virtual ICollection<QuizMultiple> QuizMultiples { get; set; }
    }
}
