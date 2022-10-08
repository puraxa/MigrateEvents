using System;
using System.Collections.Generic;

namespace MigrateEvents.Models
{
    public partial class Report
    {
        public Report()
        {
            ReportCleries = new HashSet<ReportClery>();
            ReportNotes = new HashSet<ReportNote>();
            ReportsAlerts = new HashSet<ReportsAlert>();
            ReportsKnowns = new HashSet<ReportsKnown>();
            ReportsUnknowns = new HashSet<ReportsUnknown>();
            UploadedFiles = new HashSet<UploadedFile>();
        }

        public int ReportId { get; set; }
        public DateTimeOffset? ReportCreationDate { get; set; }
        public int? InstitutionId { get; set; }
        public string? ContactFn { get; set; }
        public string? ContactLn { get; set; }
        public string? ContactEmail { get; set; }
        public string? ContactPhone { get; set; }
        public string? WhoReportedType { get; set; }
        public string? WhoReportedFn { get; set; }
        public string? WhoReportedLn { get; set; }
        public string? WhoReportedCampusId { get; set; }
        public string? WhoReportedEmail { get; set; }
        public string? WhoReportedPhone { get; set; }
        public DateTimeOffset? WhenReported { get; set; }
        public DateTimeOffset? WhenOccurStart { get; set; }
        public DateTimeOffset? WhenOccurEnd { get; set; }
        public string? LocationSpecific { get; set; }
        public string? WhatHappened { get; set; }
        public string? HowLearnAbout { get; set; }
        public string? Witnesses { get; set; }
        public string? Notes { get; set; }
        public string? DispositionList { get; set; }
        public string? ClassificationList { get; set; }
        public string? Status { get; set; }
        public int? ReportTypeId { get; set; }
        public string? PublicReportType { get; set; }
        public string? PreviouslyReported { get; set; }
        public int? RelatedTrip { get; set; }
        public string? CaseNumber { get; set; }
        public bool? TimeWarn { get; set; }
        public string? Twnotes { get; set; }
        public DateTimeOffset? TwreviewDate { get; set; }
        public int? GeographyId { get; set; }
        public string? CleryReview { get; set; }
        public string? CleryReviewNote { get; set; }
        public DateTimeOffset? CleryReviewDate { get; set; }
        public string? SafetyReportId { get; set; }
        public string? ConductReportId { get; set; }
        public int? TwassessmentId { get; set; }
        public int? AssociatedDcl { get; set; }
        public string? Dclrequired { get; set; }
        public string? Dclnote { get; set; }
        public DateTimeOffset? Dcldate { get; set; }
        public string? TitleIxid { get; set; }
        public string? LocalLawId { get; set; }
        public int? RelatedLleaid { get; set; }
        public string? FireCause { get; set; }
        public string? FireCauseUnintentional { get; set; }
        public int? FireInjured { get; set; }
        public int? FireDeath { get; set; }
        public string? FireDamage { get; set; }
        public string? PeopleNotes { get; set; }
        public string? FireNature { get; set; }
        public string? FireCauseIntentional { get; set; }
        public string? RelatedReports { get; set; }

        public virtual DailyCrimeLog? AssociatedDclNavigation { get; set; }
        public virtual Geography? Geography { get; set; }
        public virtual Institution? Institution { get; set; }
        public virtual Llea? RelatedLlea { get; set; }
        public virtual TravelAuth? RelatedTripNavigation { get; set; }
        public virtual ReportType? ReportType { get; set; }
        public virtual ReportsTwassessment? Twassessment { get; set; }
        public virtual ICollection<ReportClery> ReportCleries { get; set; }
        public virtual ICollection<ReportNote> ReportNotes { get; set; }
        public virtual ICollection<ReportsAlert> ReportsAlerts { get; set; }
        public virtual ICollection<ReportsKnown> ReportsKnowns { get; set; }
        public virtual ICollection<ReportsUnknown> ReportsUnknowns { get; set; }
        public virtual ICollection<UploadedFile> UploadedFiles { get; set; }
    }
}
