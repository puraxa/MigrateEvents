using System;
using System.Collections.Generic;

namespace MigrateEvents.Models
{
    public partial class DailyCrimeLogHistory
    {
        public DailyCrimeLogHistory()
        {
            DailyCrimeLogs = new HashSet<DailyCrimeLog>();
        }

        public int DailyCrimeLogHistoryId { get; set; }
        public DateTimeOffset? Dcloccur { get; set; }
        public DateTimeOffset? Dclreported { get; set; }
        public string? Dcllocation { get; set; }
        public string? Dclclassification { get; set; }
        public string? Dcldisposition { get; set; }
        public string? DclnotesPublic { get; set; }
        public int Dclid { get; set; }
        public DateTimeOffset? DcllastUpdatedTime { get; set; }
        public string? DcllastUpdatedUser { get; set; }
        public DateTimeOffset? DclrecentPulishTime { get; set; }
        public string? DclrecentPublishUser { get; set; }

        public virtual ICollection<DailyCrimeLog> DailyCrimeLogs { get; set; }
    }
}
