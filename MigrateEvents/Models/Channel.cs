using System;
using System.Collections.Generic;

namespace MigrateEvents.Models
{
    public partial class Channel
    {
        public Channel()
        {
            ChannelEmails = new HashSet<ChannelEmail>();
        }

        public int ChannelId { get; set; }
        public int InstitutionId { get; set; }
        public string AlertType { get; set; } = null!;
        public string ChannelType { get; set; } = null!;
        public string? Name { get; set; }
        public bool? Active { get; set; }

        public virtual Institution Institution { get; set; } = null!;
        public virtual ICollection<ChannelEmail> ChannelEmails { get; set; }
    }
}
