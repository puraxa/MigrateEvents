using System;
using System.Collections.Generic;

namespace MigrateEvents.Models
{
    public partial class Traveller
    {
        public Traveller()
        {
            UploadedFiles = new HashSet<UploadedFile>();
        }

        public int TravellerId { get; set; }
        public int TravelAuthId { get; set; }
        public int UserId { get; set; }
        public int UserTypeId { get; set; }
        public bool? WaviersAccepted { get; set; }
        public bool? Signature { get; set; }
        public DateTimeOffset? SignatureDate { get; set; }
        public DateTimeOffset? WaviersDate { get; set; }
        public bool? Acknowledge { get; set; }
        public DateTimeOffset? AcknowledgeDate { get; set; }
        public string? Goods { get; set; }
        public DateTimeOffset? GoodsDate { get; set; }
        public bool? Researchacknowledge { get; set; }
        public string? Research { get; set; }

        public virtual TravelAuth TravelAuth { get; set; } = null!;
        public virtual User User { get; set; } = null!;
        public virtual UserType UserType { get; set; } = null!;
        public virtual ICollection<UploadedFile> UploadedFiles { get; set; }
    }
}
