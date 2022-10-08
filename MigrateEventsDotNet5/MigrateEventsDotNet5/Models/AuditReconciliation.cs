using System;
using System.Collections.Generic;

namespace MigrateEvents.Models
{
    public partial class AuditReconciliation
    {
        public AuditReconciliation()
        {
            ReportNotes = new HashSet<ReportNote>();
        }

        public int AuditReconciliationId { get; set; }
        public int CleryCrimeId { get; set; }
        public bool? Reconciled { get; set; }
        public string? Comments { get; set; }
        public string? ReviewHistory { get; set; }
        public bool? Flagged { get; set; }

        public virtual ReportClery CleryCrime { get; set; } = null!;
        public virtual ICollection<ReportNote> ReportNotes { get; set; }
    }
}
