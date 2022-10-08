using System;
using System.Collections.Generic;

namespace MigrateEvents.Models
{
    public partial class InstitutionDepartment
    {
        public InstitutionDepartment()
        {
            CleryReports = new HashSet<CleryReport>();
            TravelAuths = new HashSet<TravelAuth>();
            Users = new HashSet<User>();
        }

        public int InstitutionDepartmentId { get; set; }
        public string Name { get; set; } = null!;
        public int InstitutionCollegeSchoolId { get; set; }

        public virtual InstitutionCollegeSchool InstitutionCollegeSchool { get; set; } = null!;
        public virtual ICollection<CleryReport> CleryReports { get; set; }
        public virtual ICollection<TravelAuth> TravelAuths { get; set; }
        public virtual ICollection<User> Users { get; set; }
    }
}
