using System;
using System.Collections.Generic;

namespace MigrateEvents.Models
{
    public partial class Llea
    {
        public Llea()
        {
            ReportNotes = new HashSet<ReportNote>();
            Reports = new HashSet<Report>();
            UploadedFiles = new HashSet<UploadedFile>();
        }

        public int Lleaid { get; set; }
        public string? LetterId { get; set; }
        public DateTimeOffset? LetterSentDate { get; set; }
        public DateTimeOffset? LetterResponseDeadline { get; set; }
        public string? LetterContent { get; set; }
        public string? LetterNotes { get; set; }
        public DateTimeOffset? LetterResponseDate { get; set; }
        public int? AgencyId { get; set; }
        public int? RelatedYear { get; set; }
        public DateTimeOffset? Letter2SentDate { get; set; }
        public DateTimeOffset? Letter2ResponseDeadline { get; set; }
        public string? Letter2Content { get; set; }
        public string? Letter2Notes { get; set; }
        public int? InstitutionId { get; set; }
        public string? OutreachStatus { get; set; }
        public string? StatusHistory { get; set; }

        public virtual CleryPoliceAddress? Agency { get; set; }
        public virtual Institution? Institution { get; set; }
        public virtual ICollection<ReportNote> ReportNotes { get; set; }
        public virtual ICollection<Report> Reports { get; set; }
        public virtual ICollection<UploadedFile> UploadedFiles { get; set; }
    }
}
