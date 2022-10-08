using System;
using System.Collections.Generic;

namespace MigrateEvents.Models
{
    public partial class ChannelEmail
    {
        public int EmailId { get; set; }
        public int ChannelId { get; set; }
        public string? Emails { get; set; }

        public virtual Channel Channel { get; set; } = null!;
    }
}
