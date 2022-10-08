using System;
using System.Collections.Generic;

namespace MigrateEvents.Models
{
    public partial class CrimeLogArchive
    {
        public int CrimeLogArchiveId { get; set; }
        public DateTime Date { get; set; }
        public int? CleryCampusId { get; set; }
        public int UploadedFileId { get; set; }
        public int CreatedBy { get; set; }
        public int InstitutionId { get; set; }
        public string? Note { get; set; }
        public int ArchiveType { get; set; }

        public virtual CleryCampus? CleryCampus { get; set; }
        public virtual User CreatedByNavigation { get; set; } = null!;
        public virtual Institution Institution { get; set; } = null!;
        public virtual UploadedFile UploadedFile { get; set; } = null!;
    }
}
