using System;
using System.Collections.Generic;

namespace MigrateEvents.Models
{
    public partial class QuizAnswer
    {
        public int QuizAnswerId { get; set; }
        public int AssignmentId { get; set; }
        public int? MultipleId { get; set; }
        public int? MultipleQuestionId { get; set; }
        public int? QuizTrueFalseId { get; set; }
        public bool QuizTrueFalseAnswer { get; set; }
        public bool CorrectAnswer { get; set; }

        public virtual QuizMultiple? Multiple { get; set; }
        public virtual MultipleQuestion? MultipleQuestion { get; set; }
        public virtual QuizTrueFalse? QuizTrueFalse { get; set; }
    }
}
