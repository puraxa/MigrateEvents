using System;
using System.Collections.Generic;

namespace MigrateEvents.Models
{
    public partial class CleryVawa
    {
        public CleryVawa()
        {
            ReportCleries = new HashSet<ReportClery>();
        }

        public int Vawaid { get; set; }
        public string Name { get; set; } = null!;
        public int? ListOrder { get; set; }

        public virtual ICollection<ReportClery> ReportCleries { get; set; }
    }
}
