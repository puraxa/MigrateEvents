using System;
using System.Collections.Generic;

namespace MigrateEvents.Models
{
    public partial class Campus
    {
        public Campus()
        {
            InstitutionCollegeSchools = new HashSet<InstitutionCollegeSchool>();
            Users = new HashSet<User>();
        }

        public int CampusId { get; set; }
        public string Name { get; set; } = null!;
        public int InstId { get; set; }

        public virtual Institution Inst { get; set; } = null!;
        public virtual ICollection<InstitutionCollegeSchool> InstitutionCollegeSchools { get; set; }
        public virtual ICollection<User> Users { get; set; }
    }
}
