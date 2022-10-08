using System;
using System.Collections.Generic;

namespace MigrateEvents.Models
{
    public partial class RiskCountry
    {
        public int RiskCountryId { get; set; }
        public int InstitutionId { get; set; }
        public int CountryId { get; set; }
        public int Severity { get; set; }

        public virtual Country Country { get; set; } = null!;
        public virtual Institution Institution { get; set; } = null!;
    }
}
