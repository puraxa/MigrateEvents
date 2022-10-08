using System;
using System.Collections.Generic;

namespace MigrateEvents.Models
{
    public partial class MissingReport
    {
        public MissingReport()
        {
            MissingOutreaches = new HashSet<MissingOutreach>();
            MissingReportAgencies = new HashSet<MissingReportAgency>();
            ReportNotes = new HashSet<ReportNote>();
            UploadedFiles = new HashSet<UploadedFile>();
        }

        public int MissingReportId { get; set; }
        public int? MissingContactId { get; set; }
        public int? InstitutionId { get; set; }
        public string? ReportWho { get; set; }
        public DateTimeOffset? ReportWhen { get; set; }
        public string? ReportToWhom { get; set; }
        public DateTimeOffset? ReportWhenTold { get; set; }
        public string? ReportWhere { get; set; }
        public string? ReferralWho { get; set; }
        public string? ReferralHow { get; set; }
        public DateTimeOffset? ReferralWhen { get; set; }
        public string? DeterminationStatus { get; set; }
        public DateTimeOffset? DeterminationWhen { get; set; }
        public string? DeterminationWho { get; set; }
        public string? AdminReportId { get; set; }
        public string? AdminLleaid { get; set; }
        public string? AdminPubSafetyId { get; set; }
        public string? AdminNotes { get; set; }
        public string? AdminStatus { get; set; }
        public string? AdminIncidentId { get; set; }

        public virtual Institution? Institution { get; set; }
        public virtual MissingContact? MissingContact { get; set; }
        public virtual ICollection<MissingOutreach> MissingOutreaches { get; set; }
        public virtual ICollection<MissingReportAgency> MissingReportAgencies { get; set; }
        public virtual ICollection<ReportNote> ReportNotes { get; set; }
        public virtual ICollection<UploadedFile> UploadedFiles { get; set; }
    }
}
