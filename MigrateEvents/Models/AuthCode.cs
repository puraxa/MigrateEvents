using System;
using System.Collections.Generic;

namespace MigrateEvents.Models
{
    public partial class AuthCode
    {
        public Guid AuthCodeId { get; set; }
        public int UserId { get; set; }
        public DateTimeOffset CreatedOn { get; set; }
        public DateTimeOffset LastAccessedOn { get; set; }
        public string IpAddress { get; set; } = null!;

        public virtual User User { get; set; } = null!;
    }
}
