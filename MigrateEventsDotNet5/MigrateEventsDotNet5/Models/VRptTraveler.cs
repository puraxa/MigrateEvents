using System;
using System.Collections.Generic;

namespace MigrateEvents.Models
{
    public partial class VRptTraveler
    {
        public int? InstitutionId { get; set; }
        public int? TravelAuthId { get; set; }
        public string? Name { get; set; }
        public DateTimeOffset? StartDate { get; set; }
        public DateTimeOffset? EndDate { get; set; }
        public int TravellerId { get; set; }
        public int? UserId { get; set; }
        public string? Gender { get; set; }
        public string? Fullname { get; set; }
        public int InstitutionCollegeSchoolId { get; set; }
        public string CollegeName { get; set; } = null!;
        public int InstitutionDepartmentId { get; set; }
        public string DepartmentName { get; set; } = null!;
        public int UserTypeId { get; set; }
        public string? Role { get; set; }
    }
}
