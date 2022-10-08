using System;
using System.Collections.Generic;

namespace MigrateEvents.Models
{
    public partial class ReportsUnknown
    {
        public int UnknownId { get; set; }
        public string? Gender { get; set; }
        public string? Height { get; set; }
        public string? Weight { get; set; }
        public string? Age { get; set; }
        public string? Race { get; set; }
        public string? UnknownType { get; set; }
        public int? ReportId { get; set; }

        public virtual Report? Report { get; set; }
    }
}
