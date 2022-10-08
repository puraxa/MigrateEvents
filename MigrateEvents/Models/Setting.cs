using System;
using System.Collections.Generic;

namespace MigrateEvents.Models
{
    public partial class Setting
    {
        public int SettingId { get; set; }
        public string Name { get; set; } = null!;
        public string? Value { get; set; }
        public int? InstitutionId { get; set; }

        public virtual Institution? Institution { get; set; }
    }
}
