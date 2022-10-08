using System;
using System.Collections.Generic;

namespace MigrateEvents.Models
{
    public partial class CleryCause
    {
        public CleryCause()
        {
            ReportCleries = new HashSet<ReportClery>();
        }

        public int CauseId { get; set; }
        public string Name { get; set; } = null!;
        public int? ListOrder { get; set; }

        public virtual ICollection<ReportClery> ReportCleries { get; set; }
    }
}
