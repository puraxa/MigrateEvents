using System;
using System.Collections.Generic;

namespace MigrateEvents.Models
{
    public partial class UploadedFile
    {
        public UploadedFile()
        {
            GeographyMaps = new HashSet<GeographyMap>();
            Passports = new HashSet<Passport>();
        }

        public int UploadedFileId { get; set; }
        public string Name { get; set; } = null!;
        public string? Description { get; set; }
        public int UploadedBy { get; set; }
        public DateTime DateOfUpload { get; set; }
        public string Uri { get; set; } = null!;
        public int? TravellerId { get; set; }
        public int? ReportId { get; set; }
        public int? DailyCrimeLogId { get; set; }
        public int? Lleaid { get; set; }
        public string? Section { get; set; }
        public int? UserTypeId { get; set; }
        public int? InstitutionId { get; set; }
        public int? MissingId { get; set; }
        public int? AlertsOrganizerId { get; set; }
        public int? TrainingLessonId { get; set; }

        public virtual AlertsOrganizer? AlertsOrganizer { get; set; }
        public virtual DailyCrimeLog? DailyCrimeLog { get; set; }
        public virtual Institution? Institution { get; set; }
        public virtual Llea? Llea { get; set; }
        public virtual MissingReport? Missing { get; set; }
        public virtual Report? Report { get; set; }
        public virtual TrainingLesson? TrainingLesson { get; set; }
        public virtual Traveller? Traveller { get; set; }
        public virtual UserType? UserType { get; set; }
        public virtual CrimeLogArchive? CrimeLogArchive { get; set; }
        public virtual ICollection<GeographyMap> GeographyMaps { get; set; }
        public virtual ICollection<Passport> Passports { get; set; }
    }
}
