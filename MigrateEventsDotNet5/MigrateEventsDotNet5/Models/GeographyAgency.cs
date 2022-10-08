using System;
using System.Collections.Generic;

namespace MigrateEvents.Models
{
    public partial class GeographyAgency
    {
        public int AgencyLinkId { get; set; }
        public int AgencyId { get; set; }
        public int? GeographyId { get; set; }

        public virtual CleryPoliceAddress Agency { get; set; } = null!;
        public virtual Geography? Geography { get; set; }
    }
}
