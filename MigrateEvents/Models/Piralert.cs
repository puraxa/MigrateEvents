using System;
using System.Collections.Generic;

namespace MigrateEvents.Models
{
    public partial class Piralert
    {
        public int PiralertId { get; set; }
        public int InstitutionId { get; set; }
        public string? Type { get; set; }
        public string? Recipients { get; set; }

        public virtual Institution Institution { get; set; } = null!;
    }
}
