using System;
using System.Collections.Generic;

namespace MigrateEvents.Models
{
    public partial class DailyCrimeLog
    {
        public DailyCrimeLog()
        {
            Reports = new HashSet<Report>();
            UploadedFiles = new HashSet<UploadedFile>();
        }

        public int DailyCrimeLogId { get; set; }
        public DateTimeOffset? Dcloccur { get; set; }
        public DateTimeOffset? Dclreported { get; set; }
        public string? Dcllocation { get; set; }
        public string? Dclclassification { get; set; }
        public string? Dcldisposition { get; set; }
        public string? DclnotesPublic { get; set; }
        public string? DclcaseNumber { get; set; }
        public string? DclwhoReviewed { get; set; }
        public DateTimeOffset? DclwhenReviewed { get; set; }
        public string? DclwhoPublished { get; set; }
        public DateTimeOffset? DclwhenPublished { get; set; }
        public string? DclnotesInternal { get; set; }
        public string? PublicationStatus { get; set; }
        public int? InstitutionId { get; set; }
        public string? Status { get; set; }
        public DateTimeOffset? DcloccurEnd { get; set; }
        public int? CleryCampusId { get; set; }
        public string? DclreportCaseNumber { get; set; }
        public string? Dcldelayed { get; set; }
        public string? DcldelayReason { get; set; }
        public string? DclisInfoWithheld { get; set; }
        public string? DclwithheldReason { get; set; }
        public string? DclwithheldDetails { get; set; }
        public int? DailyCrimeLogHistoryId { get; set; }

        public virtual CleryCampus? CleryCampus { get; set; }
        public virtual DailyCrimeLogHistory? DailyCrimeLogHistory { get; set; }
        public virtual Institution? Institution { get; set; }
        public virtual ICollection<Report> Reports { get; set; }
        public virtual ICollection<UploadedFile> UploadedFiles { get; set; }
    }
}
