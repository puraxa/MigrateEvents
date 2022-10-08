using System;
using System.Collections.Generic;

namespace MigrateEvents.Models
{
    public partial class ReportClery
    {
        public int ReportCleryId { get; set; }
        public int ReportId { get; set; }
        public int? HateCrimeId { get; set; }
        public int? HateCrimeCategoryId { get; set; }
        public int? Vawaid { get; set; }
        public int? ArrestsId { get; set; }
        public bool? Unfounded { get; set; }
        public bool? HierRule { get; set; }
        public int? CleryClassificationId { get; set; }
        public int? ReportCleryTypeId { get; set; }
        public string? CleryRationale { get; set; }

        public virtual CleryArrest? Arrests { get; set; }
        public virtual CleryClassification? CleryClassification { get; set; }
        public virtual CleryCause? HateCrime { get; set; }
        public virtual CleryCategory? HateCrimeCategory { get; set; }
        public virtual Report Report { get; set; } = null!;
        public virtual ReportCleryType? ReportCleryType { get; set; }
        public virtual CleryVawa? Vawa { get; set; }
        public virtual AuditReconciliation? AuditReconciliation { get; set; }
    }
}
