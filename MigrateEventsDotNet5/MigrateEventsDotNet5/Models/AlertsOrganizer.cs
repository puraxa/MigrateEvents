using System;
using System.Collections.Generic;

namespace MigrateEvents.Models
{
    public partial class AlertsOrganizer
    {
        public AlertsOrganizer()
        {
            ReportsAlerts = new HashSet<ReportsAlert>();
            UploadedFiles = new HashSet<UploadedFile>();
        }

        public int Aoid { get; set; }
        public string Atype { get; set; } = null!;
        public string CaseId { get; set; } = null!;
        public int? HeaderId { get; set; }
        public string? Msg { get; set; }
        public int? SafetyId { get; set; }
        public int? FooterId { get; set; }
        public string? CreatedBy { get; set; }
        public DateTimeOffset? CreatedOn { get; set; }
        public string? PublishedBy { get; set; }
        public DateTimeOffset? PublishedOn { get; set; }
        public string? Notes { get; set; }
        public int? InstitutionId { get; set; }
        public string? PublicationChannels { get; set; }
        public int? PreviousAoid { get; set; }
        public string? OtherId { get; set; }
        public string? MsgSubject { get; set; }
        public bool? IsLog { get; set; }

        public virtual Boilerplate? Footer { get; set; }
        public virtual Boilerplate? Header { get; set; }
        public virtual Institution? Institution { get; set; }
        public virtual Boilerplate? Safety { get; set; }
        public virtual ICollection<ReportsAlert> ReportsAlerts { get; set; }
        public virtual ICollection<UploadedFile> UploadedFiles { get; set; }
    }
}
