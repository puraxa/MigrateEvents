using System;
using System.Collections.Generic;

namespace MigrateEvents.Models
{
    public partial class CleryCsalistHistory
    {
        public int CleryCsalistHistoryId { get; set; }
        public int UserId { get; set; }
        public DateTimeOffset? ActualDate { get; set; }
        public DateTimeOffset ActualYear { get; set; }

        public virtual User User { get; set; } = null!;
    }
}
