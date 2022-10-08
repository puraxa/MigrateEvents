using System;
using System.Collections.Generic;

namespace MigrateEvents.Models
{
    public partial class Institution
    {
        public Institution()
        {
            Alerts = new HashSet<Alert>();
            AlertsOrganizers = new HashSet<AlertsOrganizer>();
            Boilerplates = new HashSet<Boilerplate>();
            Campuses = new HashSet<Campus>();
            Channels = new HashSet<Channel>();
            CleryCampuses = new HashSet<CleryCampus>();
            CrimeLogArchives = new HashSet<CrimeLogArchive>();
            DailyCrimeLogs = new HashSet<DailyCrimeLog>();
            Dcrclassifications = new HashSet<Dcrclassification>();
            Dispositions = new HashSet<Disposition>();
            Emails = new HashSet<Email>();
            Genders = new HashSet<Gender>();
            Geographies = new HashSet<Geography>();
            GeographyMaps = new HashSet<GeographyMap>();
            InstitutionCollegeSchools = new HashSet<InstitutionCollegeSchool>();
            InstitutionEmails = new HashSet<InstitutionEmail>();
            Lleas = new HashSet<Llea>();
            MissingContacts = new HashSet<MissingContact>();
            MissingReports = new HashSet<MissingReport>();
            Piralerts = new HashSet<Piralert>();
            Reports = new HashSet<Report>();
            RiskCountries = new HashSet<RiskCountry>();
            Settings = new HashSet<Setting>();
            SiteContents = new HashSet<SiteContent>();
            TrainingCourses = new HashSet<TrainingCourse>();
            UploadedFiles = new HashSet<UploadedFile>();
            UserTypes = new HashSet<UserType>();
            Users = new HashSet<User>();
        }

        public int InstitutionId { get; set; }
        public string Name { get; set; } = null!;
        public string Address1 { get; set; } = null!;
        public string Address2 { get; set; } = null!;
        public string? Address3 { get; set; }
        public string City { get; set; } = null!;
        public string? StateAbr { get; set; }
        public int CountryId { get; set; }
        public string ContactNumber { get; set; } = null!;
        public bool? Deleted { get; set; }
        public string? AdminTitle { get; set; }
        public string? AdminFirstname { get; set; }
        public string? AdminLastname { get; set; }
        public string? AdminEmail { get; set; }
        public string? AdminPhone { get; set; }
        public string? ResearchFirstname { get; set; }
        public string? ResearchLastname { get; set; }
        public string? ResearchEmail { get; set; }
        public string? ExportFirstname { get; set; }
        public string? ExportLastname { get; set; }
        public string? ExportEmail { get; set; }
        public string? ResearchPhone { get; set; }
        public string? ExportPhone { get; set; }
        public string? BusinessFirstname { get; set; }
        public string? BusinessLastname { get; set; }
        public string? BusinessEmail { get; set; }
        public string? BusinessPhone { get; set; }
        public bool? Inactive { get; set; }
        public string? PostalCode { get; set; }
        public bool? UsesTripTracker { get; set; }
        public bool? UsesIncidentReporter { get; set; }
        public bool? UsesCleryManager { get; set; }
        public string? CleryFirstname { get; set; }
        public string? CleryLastname { get; set; }
        public string? CleryEmail { get; set; }
        public string? CleryPhone { get; set; }
        public string? CorrespondenceLetter { get; set; }
        public string? CorrespondenceSubject { get; set; }
        public string? CorrespondenceEmails { get; set; }
        public string? TimeZone { get; set; }
        public string? RemoteId { get; set; }
        public DateTimeOffset? DateJoined { get; set; }
        public DateTimeOffset? CsaletterDate { get; set; }
        public string? CsaletterMsg { get; set; }
        public string? CsaletterSubject { get; set; }
        public int? CsaletterClassification { get; set; }
        public string? GeneralEmailSender { get; set; }
        public string? GeneralEmailAddress { get; set; }
        public string? CleryManagerEmailSender { get; set; }
        public string? CleryManagerEmailAddress { get; set; }
        public string? IncidentReporterEmailSender { get; set; }
        public string? IncidentReporterEmailAddress { get; set; }
        public string? TripTrackerEmailSender { get; set; }
        public string? TripTrackerEmailAddress { get; set; }
        public string? AlertsOrganizerEmailSender { get; set; }
        public string? AlertsOrganizerEmailAddress { get; set; }
        public bool? ModGeography { get; set; }
        public bool? ModLlea { get; set; }
        public bool? ModCsas { get; set; }
        public bool? ModIncidents1 { get; set; }
        public bool? ModIncidents2 { get; set; }
        public bool? ModCleryAudit { get; set; }
        public bool? ModDcl { get; set; }
        public bool? ModAlerts { get; set; }
        public string? WebAddress { get; set; }
        public string? DclmanagerEmailSender { get; set; }
        public string? DclmanagerEmailAddress { get; set; }
        public string? MissingStudentLetter { get; set; }
        public string? MissingStudentLetterSubject { get; set; }
        public string? MissingStudentLetterEmails { get; set; }
        public bool? ModStudentResidence { get; set; }
        public string? CleryCsareportLetterMsg { get; set; }
        public string? CleryCsareportLetterSubject { get; set; }
        public int? CleryCsareportLetterClassification { get; set; }
        public DateTimeOffset? CleryCsareportLetterDate { get; set; }

        public virtual Country Country { get; set; } = null!;
        public virtual State? StateAbrNavigation { get; set; }
        public virtual TwilioCredential? TwilioCredential { get; set; }
        public virtual ICollection<Alert> Alerts { get; set; }
        public virtual ICollection<AlertsOrganizer> AlertsOrganizers { get; set; }
        public virtual ICollection<Boilerplate> Boilerplates { get; set; }
        public virtual ICollection<Campus> Campuses { get; set; }
        public virtual ICollection<Channel> Channels { get; set; }
        public virtual ICollection<CleryCampus> CleryCampuses { get; set; }
        public virtual ICollection<CrimeLogArchive> CrimeLogArchives { get; set; }
        public virtual ICollection<DailyCrimeLog> DailyCrimeLogs { get; set; }
        public virtual ICollection<Dcrclassification> Dcrclassifications { get; set; }
        public virtual ICollection<Disposition> Dispositions { get; set; }
        public virtual ICollection<Email> Emails { get; set; }
        public virtual ICollection<Gender> Genders { get; set; }
        public virtual ICollection<Geography> Geographies { get; set; }
        public virtual ICollection<GeographyMap> GeographyMaps { get; set; }
        public virtual ICollection<InstitutionCollegeSchool> InstitutionCollegeSchools { get; set; }
        public virtual ICollection<InstitutionEmail> InstitutionEmails { get; set; }
        public virtual ICollection<Llea> Lleas { get; set; }
        public virtual ICollection<MissingContact> MissingContacts { get; set; }
        public virtual ICollection<MissingReport> MissingReports { get; set; }
        public virtual ICollection<Piralert> Piralerts { get; set; }
        public virtual ICollection<Report> Reports { get; set; }
        public virtual ICollection<RiskCountry> RiskCountries { get; set; }
        public virtual ICollection<Setting> Settings { get; set; }
        public virtual ICollection<SiteContent> SiteContents { get; set; }
        public virtual ICollection<TrainingCourse> TrainingCourses { get; set; }
        public virtual ICollection<UploadedFile> UploadedFiles { get; set; }
        public virtual ICollection<UserType> UserTypes { get; set; }
        public virtual ICollection<User> Users { get; set; }
    }
}
