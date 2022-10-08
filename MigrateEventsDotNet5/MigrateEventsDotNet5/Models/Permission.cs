using System;
using System.Collections.Generic;

namespace MigrateEvents.Models
{
    public partial class Permission
    {
        public Permission()
        {
            UserTypePermissions = new HashSet<UserTypePermission>();
        }

        public int PermissionId { get; set; }
        public string Name { get; set; } = null!;
        public string Description { get; set; } = null!;
        public string? ReadableName { get; set; }
        public int? Module { get; set; }
        public int? GroupId { get; set; }

        public virtual PermissionGroup? Group { get; set; }
        public virtual ICollection<UserTypePermission> UserTypePermissions { get; set; }
    }
}
