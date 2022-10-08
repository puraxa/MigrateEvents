using System;
using System.Collections.Generic;

namespace MigrateEvents.Models
{
    public partial class TravelAuth
    {
        public TravelAuth()
        {
            CleryReports = new HashSet<CleryReport>();
            ExportControls = new HashSet<ExportControl>();
            Flights = new HashSet<Flight>();
            Itineraries = new HashSet<Itinerary>();
            Rentals = new HashSet<Rental>();
            Reports = new HashSet<Report>();
            Researches = new HashSet<Research>();
            Travellers = new HashSet<Traveller>();
        }

        public int TravelAuthId { get; set; }
        public int UserId { get; set; }
        public string? ApprovalIndividual { get; set; }
        public string? ApprovalPhone { get; set; }
        public string? FundingSchool { get; set; }
        public decimal? FundingAmount { get; set; }
        public string? FacultyAdvisor { get; set; }
        public string? DepartmentChair { get; set; }
        public bool? Deleted { get; set; }
        public string Name { get; set; } = null!;
        public string? Status { get; set; }
        public bool? ContentComplete { get; set; }
        public bool? Sevendayemail { get; set; }
        public bool? Onedayemail { get; set; }
        public string? ApprovalEmail { get; set; }
        public DateTimeOffset? StartDate { get; set; }
        public DateTimeOffset? EndDate { get; set; }
        public bool? Imported { get; set; }
        public int? ContactUnitId { get; set; }
        public int? ContactSubUnitId { get; set; }
        public string? UniqueId { get; set; }
        public int? ApprovalUnitId { get; set; }
        public int? ApprovalSubunitId { get; set; }
        public bool? Solo { get; set; }
        public bool? Twodayreturnemail { get; set; }

        public virtual InstitutionDepartment? ContactSubUnit { get; set; }
        public virtual InstitutionCollegeSchool? ContactUnit { get; set; }
        public virtual User User { get; set; } = null!;
        public virtual ICollection<CleryReport> CleryReports { get; set; }
        public virtual ICollection<ExportControl> ExportControls { get; set; }
        public virtual ICollection<Flight> Flights { get; set; }
        public virtual ICollection<Itinerary> Itineraries { get; set; }
        public virtual ICollection<Rental> Rentals { get; set; }
        public virtual ICollection<Report> Reports { get; set; }
        public virtual ICollection<Research> Researches { get; set; }
        public virtual ICollection<Traveller> Travellers { get; set; }
    }
}
