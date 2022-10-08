using System;
using System.Collections.Generic;

namespace MigrateEvents.Models
{
    public partial class GeographyMap
    {
        public int GeographyMapsId { get; set; }
        public string? MapId { get; set; }
        public string? Name { get; set; }
        public int? CleryCampusId { get; set; }
        public string? Type { get; set; }
        public DateTimeOffset? StartDate { get; set; }
        public DateTimeOffset? EndDate { get; set; }
        public string? Notes { get; set; }
        public bool? Archived { get; set; }
        public int? InstitutionId { get; set; }
        public int? UploadedFileId { get; set; }

        public virtual CleryCampus? CleryCampus { get; set; }
        public virtual Institution? Institution { get; set; }
        public virtual UploadedFile? UploadedFile { get; set; }
    }
}
