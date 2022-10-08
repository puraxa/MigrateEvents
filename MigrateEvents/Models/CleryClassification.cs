using System;
using System.Collections.Generic;

namespace MigrateEvents.Models
{
    public partial class CleryClassification
    {
        public CleryClassification()
        {
            ReportCleries = new HashSet<ReportClery>();
        }

        public int ClassificationId { get; set; }
        public string? Name { get; set; }
        public int? ListOrder { get; set; }

        public virtual ICollection<ReportClery> ReportCleries { get; set; }
    }
}
