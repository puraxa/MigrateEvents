using System;
using System.Collections.Generic;

namespace MigrateEvents.Models
{
    public partial class User
    {
        public User()
        {
            Alerts = new HashSet<Alert>();
            AuthCodes = new HashSet<AuthCode>();
            CleryCsalistHistories = new HashSet<CleryCsalistHistory>();
            CleryPoliceAddresses = new HashSet<CleryPoliceAddress>();
            CrimeLogArchives = new HashSet<CrimeLogArchive>();
            EmergencyContacts = new HashSet<EmergencyContact>();
            ExportControls = new HashSet<ExportControl>();
            Flights = new HashSet<Flight>();
            Insurances = new HashSet<Insurance>();
            Itineraries = new HashSet<Itinerary>();
            Medicals = new HashSet<Medical>();
            MessageRecepients = new HashSet<Message>();
            MessageSenders = new HashSet<Message>();
            Passports = new HashSet<Passport>();
            Rentals = new HashSet<Rental>();
            ReportNotes = new HashSet<ReportNote>();
            ReportsTwassessmentReviewers = new HashSet<ReportsTwassessmentReviewer>();
            ReportsTwassessments = new HashSet<ReportsTwassessment>();
            Researches = new HashSet<Research>();
            TrainingCourses = new HashSet<TrainingCourse>();
            TravelAuths = new HashSet<TravelAuth>();
            Travellers = new HashSet<Traveller>();
        }

        public int UserId { get; set; }
        public int UserTypeId { get; set; }
        public string PrimaryEmail { get; set; } = null!;
        public string? SecondaryEmail { get; set; }
        public string Password { get; set; } = null!;
        public string FirstName { get; set; } = null!;
        public string? MiddleName { get; set; }
        public string LastName { get; set; } = null!;
        public string? Suffix { get; set; }
        public int InstitutionId { get; set; }
        public DateTimeOffset? Dob { get; set; }
        public int? GenderId { get; set; }
        public string PrimaryPhone { get; set; } = null!;
        public string? SecondaryPhone { get; set; }
        public string MobilePhone { get; set; } = null!;
        public bool? TrackMobile { get; set; }
        public string EmergencyContactType { get; set; } = null!;
        public bool? Deleted { get; set; }
        public string? Title { get; set; }
        public string? BusEmail { get; set; }
        public string? BusPhone { get; set; }
        public int? InstitutionDepartmentId { get; set; }
        public string? UniversityId { get; set; }
        public bool? Deactivated { get; set; }
        public int? DefaultRoleId { get; set; }
        public string? Code { get; set; }
        public int? CampusId { get; set; }
        public int? UnitId { get; set; }
        public DateTimeOffset? TermsAcceptedDate { get; set; }
        public string? Salt { get; set; }

        public virtual Campus? Campus { get; set; }
        public virtual UserType? DefaultRole { get; set; }
        public virtual Gender? Gender { get; set; }
        public virtual Institution Institution { get; set; } = null!;
        public virtual InstitutionDepartment? InstitutionDepartment { get; set; }
        public virtual UserType UserType { get; set; } = null!;
        public virtual CleryCsauser? CleryCsauser { get; set; }
        public virtual ICollection<Alert> Alerts { get; set; }
        public virtual ICollection<AuthCode> AuthCodes { get; set; }
        public virtual ICollection<CleryCsalistHistory> CleryCsalistHistories { get; set; }
        public virtual ICollection<CleryPoliceAddress> CleryPoliceAddresses { get; set; }
        public virtual ICollection<CrimeLogArchive> CrimeLogArchives { get; set; }
        public virtual ICollection<EmergencyContact> EmergencyContacts { get; set; }
        public virtual ICollection<ExportControl> ExportControls { get; set; }
        public virtual ICollection<Flight> Flights { get; set; }
        public virtual ICollection<Insurance> Insurances { get; set; }
        public virtual ICollection<Itinerary> Itineraries { get; set; }
        public virtual ICollection<Medical> Medicals { get; set; }
        public virtual ICollection<Message> MessageRecepients { get; set; }
        public virtual ICollection<Message> MessageSenders { get; set; }
        public virtual ICollection<Passport> Passports { get; set; }
        public virtual ICollection<Rental> Rentals { get; set; }
        public virtual ICollection<ReportNote> ReportNotes { get; set; }
        public virtual ICollection<ReportsTwassessmentReviewer> ReportsTwassessmentReviewers { get; set; }
        public virtual ICollection<ReportsTwassessment> ReportsTwassessments { get; set; }
        public virtual ICollection<Research> Researches { get; set; }
        public virtual ICollection<TrainingCourse> TrainingCourses { get; set; }
        public virtual ICollection<TravelAuth> TravelAuths { get; set; }
        public virtual ICollection<Traveller> Travellers { get; set; }
    }
}
