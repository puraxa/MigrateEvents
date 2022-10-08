using System;
using System.Collections.Generic;

namespace MigrateEvents.Models
{
    public partial class CleryCsahistory
    {
        public int CleryCsahistoryId { get; set; }
        public int CleryCsaid { get; set; }
        public DateTimeOffset? ActualDate { get; set; }
        public DateTimeOffset ActualYear { get; set; }

        public virtual CleryCsauser CleryCsa { get; set; } = null!;
    }
}
