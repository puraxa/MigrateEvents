using System;
using System.Collections.Generic;

namespace MigrateEvents.Models
{
    public partial class ReportsTwassessment
    {
        public ReportsTwassessment()
        {
            Reports = new HashSet<Report>();
            ReportsTwassessmentReviewers = new HashSet<ReportsTwassessmentReviewer>();
        }

        public int ReportsTwassessmentId { get; set; }
        public string? Twrequired { get; set; }
        public string? Notes { get; set; }
        public DateTimeOffset? DateReviewed { get; set; }
        public string? Twsupporting { get; set; }
        public string? TwnotSupporting { get; set; }
        public string? IsInfoWithheld { get; set; }
        public string? InfoWithheldDetails { get; set; }
        public int? ReviewerId { get; set; }
        public string? Enrequired { get; set; }
        public string? Ennotes { get; set; }
        public DateTimeOffset? EndateReviewed { get; set; }

        public virtual User? Reviewer { get; set; }
        public virtual ICollection<Report> Reports { get; set; }
        public virtual ICollection<ReportsTwassessmentReviewer> ReportsTwassessmentReviewers { get; set; }
    }
}
