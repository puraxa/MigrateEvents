using System;
using System.Collections.Generic;

namespace MigrateEvents.Models
{
    public partial class ReportCleryType
    {
        public ReportCleryType()
        {
            ReportCleries = new HashSet<ReportClery>();
        }

        public int ReportCleryTypeId { get; set; }
        public string Name { get; set; } = null!;

        public virtual ICollection<ReportClery> ReportCleries { get; set; }
    }
}
