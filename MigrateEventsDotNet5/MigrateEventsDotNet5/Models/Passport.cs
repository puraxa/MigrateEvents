using System;
using System.Collections.Generic;

namespace MigrateEvents.Models
{
    public partial class Passport
    {
        public int PassportId { get; set; }
        public int UserId { get; set; }
        public int Citizenship { get; set; }
        public int IssuedBy { get; set; }
        public string PassportNumber { get; set; } = null!;
        public DateTimeOffset DateIssuedOn { get; set; }
        public DateTimeOffset DateExpiresOn { get; set; }
        public string? Emergency { get; set; }
        public int? UploadedFileId { get; set; }

        public virtual Country CitizenshipNavigation { get; set; } = null!;
        public virtual Country IssuedByNavigation { get; set; } = null!;
        public virtual UploadedFile? UploadedFile { get; set; }
        public virtual User User { get; set; } = null!;
    }
}
