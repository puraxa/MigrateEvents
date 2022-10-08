using System;
using System.Collections.Generic;

namespace MigrateEvents.Models
{
    public partial class CleryCategory
    {
        public CleryCategory()
        {
            ReportCleries = new HashSet<ReportClery>();
        }

        public int CategoryId { get; set; }
        public string? Name { get; set; }
        public int? ListOrder { get; set; }

        public virtual ICollection<ReportClery> ReportCleries { get; set; }
    }
}
