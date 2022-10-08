using System;
using System.Collections.Generic;

namespace MigrateEvents.Models
{
    public partial class ReportsAlert
    {
        public int ReportsAlertId { get; set; }
        public int ReportId { get; set; }
        public int Aoid { get; set; }

        public virtual AlertsOrganizer Ao { get; set; } = null!;
        public virtual Report Report { get; set; } = null!;
    }
}
