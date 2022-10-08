using System;
using System.Collections.Generic;

namespace MigrateEvents.Models
{
    public partial class MissingOutreach
    {
        public int MissingOutreachId { get; set; }
        public string? ContactName { get; set; }
        public DateTimeOffset? WhenContacted { get; set; }
        public string? WhoContacted { get; set; }
        public string? HowContacted { get; set; }
        public string? Notes { get; set; }
        public int? MissingReportId { get; set; }

        public virtual MissingReport? MissingReport { get; set; }
    }
}
