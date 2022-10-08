using System;
using System.Collections.Generic;

namespace MigrateEvents.Models
{
    public partial class InstitutionCollegeSchool
    {
        public InstitutionCollegeSchool()
        {
            CleryReports = new HashSet<CleryReport>();
            InstitutionDepartments = new HashSet<InstitutionDepartment>();
            TravelAuths = new HashSet<TravelAuth>();
        }

        public int InstitutionCollegeSchoolId { get; set; }
        public string Name { get; set; } = null!;
        public int? CampusId { get; set; }
        public int? InstitutionId { get; set; }

        public virtual Campus? Campus { get; set; }
        public virtual Institution? Institution { get; set; }
        public virtual ICollection<CleryReport> CleryReports { get; set; }
        public virtual ICollection<InstitutionDepartment> InstitutionDepartments { get; set; }
        public virtual ICollection<TravelAuth> TravelAuths { get; set; }
    }
}
