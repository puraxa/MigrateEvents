using System;
using System.Collections.Generic;

namespace MigrateEvents.Models
{
    public partial class MissingReportAgency
    {
        public int MissingReportLinkId { get; set; }
        public int? MissingReportId { get; set; }
        public int? AgencyId { get; set; }

        public virtual CleryPoliceAddress? Agency { get; set; }
        public virtual MissingReport? MissingReport { get; set; }
    }
}
