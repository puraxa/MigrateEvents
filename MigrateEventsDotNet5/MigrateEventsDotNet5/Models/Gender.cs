using System;
using System.Collections.Generic;

namespace MigrateEvents.Models
{
    public partial class Gender
    {
        public Gender()
        {
            Users = new HashSet<User>();
        }

        public int GenderId { get; set; }
        public string Name { get; set; } = null!;
        public int InstitutionId { get; set; }
        public bool Default { get; set; }

        public virtual Institution Institution { get; set; } = null!;
        public virtual ICollection<User> Users { get; set; }
    }
}
