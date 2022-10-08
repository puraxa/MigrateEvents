using System;
using System.Collections.Generic;

namespace MigrateEvents.Models
{
    public partial class ExportControl
    {
        public int ExportId { get; set; }
        public int TravelAuthId { get; set; }
        public bool? Acknowledge { get; set; }
        public string? Goods { get; set; }
        public int UserId { get; set; }

        public virtual TravelAuth TravelAuth { get; set; } = null!;
        public virtual User User { get; set; } = null!;
    }
}
