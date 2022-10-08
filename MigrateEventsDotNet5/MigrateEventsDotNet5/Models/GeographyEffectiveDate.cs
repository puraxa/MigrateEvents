using System;
using System.Collections.Generic;

namespace MigrateEvents.Models
{
    public partial class GeographyEffectiveDate
    {
        public int DateId { get; set; }
        public DateTimeOffset? StartDate { get; set; }
        public DateTimeOffset? EndDate { get; set; }
        public int? GeographyId { get; set; }

        public virtual Geography? Geography { get; set; }
    }
}
