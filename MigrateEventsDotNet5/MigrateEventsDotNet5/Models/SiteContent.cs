using System;
using System.Collections.Generic;

namespace MigrateEvents.Models
{
    public partial class SiteContent
    {
        public int ContentId { get; set; }
        public string Name { get; set; } = null!;
        public string? Data { get; set; }
        public int? InstitutionId { get; set; }

        public virtual Institution? Institution { get; set; }
    }
}
