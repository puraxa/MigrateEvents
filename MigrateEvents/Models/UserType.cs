using System;
using System.Collections.Generic;

namespace MigrateEvents.Models
{
    public partial class UserType
    {
        public UserType()
        {
            Travellers = new HashSet<Traveller>();
            UploadedFiles = new HashSet<UploadedFile>();
            UserDefaultRoles = new HashSet<User>();
            UserTypePermissions = new HashSet<UserTypePermission>();
            UserUserTypes = new HashSet<User>();
        }

        public int UserTypeId { get; set; }
        public int? InstitutionId { get; set; }
        public string Name { get; set; } = null!;

        public virtual Institution? Institution { get; set; }
        public virtual ICollection<Traveller> Travellers { get; set; }
        public virtual ICollection<UploadedFile> UploadedFiles { get; set; }
        public virtual ICollection<User> UserDefaultRoles { get; set; }
        public virtual ICollection<UserTypePermission> UserTypePermissions { get; set; }
        public virtual ICollection<User> UserUserTypes { get; set; }
    }
}
