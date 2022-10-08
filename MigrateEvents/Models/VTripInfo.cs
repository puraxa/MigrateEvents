using System;
using System.Collections.Generic;

namespace MigrateEvents.Models
{
    public partial class VTripInfo
    {
        public int TravelAuthId { get; set; }
        public int UserId { get; set; }
        public string? ApprovalIndividual { get; set; }
        public string? ApprovalPhone { get; set; }
        public string? FundingSchool { get; set; }
        public decimal? FundingAmount { get; set; }
        public string? FacultyAdvisor { get; set; }
        public string? DepartmentChair { get; set; }
        public bool? Deleted { get; set; }
        public string? Name { get; set; }
        public DateTimeOffset? StartDate { get; set; }
        public DateTimeOffset? EndDate { get; set; }
        public int? InstitutionId { get; set; }
        public string? Countries { get; set; }
        public string? TripStatus { get; set; }
        public bool? ContentComplete { get; set; }
        public bool? Sevendayemail { get; set; }
        public bool? Onedayemail { get; set; }
    }
}
