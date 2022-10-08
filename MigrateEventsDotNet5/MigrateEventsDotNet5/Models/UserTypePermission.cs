using System;
using System.Collections.Generic;

namespace MigrateEvents.Models
{
    public partial class UserTypePermission
    {
        public int UserTypePermissionId { get; set; }
        public int PermissionId { get; set; }
        public int UserTypeId { get; set; }

        public virtual Permission Permission { get; set; } = null!;
        public virtual UserType UserType { get; set; } = null!;
    }
}
