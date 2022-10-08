using System;
using System.Collections.Generic;

namespace MigrateEvents.Models
{
    public partial class ReportsKnown
    {
        public int KnownId { get; set; }
        public string? Fn { get; set; }
        public string? Ln { get; set; }
        public string? CampusId { get; set; }
        public string? Email { get; set; }
        public string? Phone { get; set; }
        public int ReportId { get; set; }
        public string? KnownType { get; set; }
        public DateTimeOffset? DateOfBirth { get; set; }

        public virtual Report Report { get; set; } = null!;
    }
}
