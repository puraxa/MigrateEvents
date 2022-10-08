using System;
using System.Collections.Generic;

namespace MigrateEvents.Models
{
    public partial class CleryCsauser
    {
        public CleryCsauser()
        {
            CleryCsahistories = new HashSet<CleryCsahistory>();
            CleryCsatrainingAssignments = new HashSet<CleryCsatrainingAssignment>();
            CleryCsauserHistories = new HashSet<CleryCsauserHistory>();
        }

        public int CleryCsaid { get; set; }
        public int UserId { get; set; }
        public DateTimeOffset? Training { get; set; }
        public bool? Archived { get; set; }
        public string? Title { get; set; }
        public int? ClassificationId { get; set; }
        public DateTimeOffset? ReportConfirmationDate { get; set; }
        public DateTimeOffset? ConfirmationDate { get; set; }
        public bool? CsalistUpdater { get; set; }
        public DateTimeOffset? DateUpdated { get; set; }
        public DateTimeOffset? CreatedOn { get; set; }
        public DateTimeOffset? ConfirmationMailDateTime { get; set; }
        public string? ConfirmationCode { get; set; }

        public virtual CleryCsaclassification? Classification { get; set; }
        public virtual User User { get; set; } = null!;
        public virtual ICollection<CleryCsahistory> CleryCsahistories { get; set; }
        public virtual ICollection<CleryCsatrainingAssignment> CleryCsatrainingAssignments { get; set; }
        public virtual ICollection<CleryCsauserHistory> CleryCsauserHistories { get; set; }
    }
}
