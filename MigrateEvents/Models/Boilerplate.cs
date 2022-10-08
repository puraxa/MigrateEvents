using System;
using System.Collections.Generic;

namespace MigrateEvents.Models
{
    public partial class Boilerplate
    {
        public Boilerplate()
        {
            AlertsOrganizerFooters = new HashSet<AlertsOrganizer>();
            AlertsOrganizerHeaders = new HashSet<AlertsOrganizer>();
            AlertsOrganizerSafeties = new HashSet<AlertsOrganizer>();
        }

        public int BpId { get; set; }
        public int InstitutionId { get; set; }
        public string? Contents { get; set; }
        public string? Section { get; set; }
        public string? ContentName { get; set; }

        public virtual Institution Institution { get; set; } = null!;
        public virtual ICollection<AlertsOrganizer> AlertsOrganizerFooters { get; set; }
        public virtual ICollection<AlertsOrganizer> AlertsOrganizerHeaders { get; set; }
        public virtual ICollection<AlertsOrganizer> AlertsOrganizerSafeties { get; set; }
    }
}
