using System;
using System.Collections.Generic;

namespace MigrateEvents.Models
{
    public partial class ReportsTwassessmentReviewer
    {
        public int ReportsTwassessmentReviewerId { get; set; }
        public int? AssessmentId { get; set; }
        public int? ReviewerId { get; set; }

        public virtual ReportsTwassessment? Assessment { get; set; }
        public virtual User? Reviewer { get; set; }
    }
}
