using System;
using System.Collections.Generic;

namespace MigrateEvents.Models
{
    public partial class ReportNote
    {
        public int ReportNoteId { get; set; }
        public int? ReportId { get; set; }
        public DateTime DateCreated { get; set; }
        public int UserId { get; set; }
        public string Note { get; set; } = null!;
        public bool IsPrivate { get; set; }
        public bool IsReminder { get; set; }
        public DateTime? ReminderDate { get; set; }
        public int? AuditReconciliationId { get; set; }
        public int? MissingId { get; set; }
        public bool? MadeByAdmin { get; set; }
        public int? Lleaid { get; set; }
        public bool Dismissed { get; set; }

        public virtual AuditReconciliation? AuditReconciliation { get; set; }
        public virtual Llea? Llea { get; set; }
        public virtual MissingReport? Missing { get; set; }
        public virtual Report? Report { get; set; }
        public virtual User User { get; set; } = null!;
    }
}
