using System;
using System.Collections.Generic;

namespace MigrateEvents.Models
{
    public partial class PermissionGroup
    {
        public PermissionGroup()
        {
            Permissions = new HashSet<Permission>();
        }

        public int GroupId { get; set; }
        public string Name { get; set; } = null!;

        public virtual ICollection<Permission> Permissions { get; set; }
    }
}
