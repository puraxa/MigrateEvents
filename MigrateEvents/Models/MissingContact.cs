using System;
using System.Collections.Generic;

namespace MigrateEvents.Models
{
    public partial class MissingContact
    {
        public MissingContact()
        {
            MissingReports = new HashSet<MissingReport>();
        }

        public int MissingContactId { get; set; }
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public int? InstitutionId { get; set; }
        public DateTimeOffset? DateOfBirth { get; set; }
        public string? Phone { get; set; }
        public string? PrimaryContactName { get; set; }
        public string? PrimaryContactAddress { get; set; }
        public string? PrimaryContactPhone1 { get; set; }
        public string? PrimaryContactPhone2 { get; set; }
        public string? PrimaryContactEmail { get; set; }
        public string? PrimaryContactRelationship { get; set; }
        public string? SecondaryContactName { get; set; }
        public string? SecondaryContactAddress { get; set; }
        public string? SecondaryContactPhone1 { get; set; }
        public string? SecondaryContactPhone2 { get; set; }
        public string? SecondaryContactEmail { get; set; }
        public string? SecondaryContactRelationship { get; set; }
        public string? StudentId { get; set; }
        public string? Email { get; set; }
        public int? Archived { get; set; }
        public DateTimeOffset? ResetDateTime { get; set; }
        public string? ThirdContactName { get; set; }
        public string? ThirdContactAddress { get; set; }
        public string? ThirdContactPhone1 { get; set; }
        public string? ThirdContactPhone2 { get; set; }
        public string? ThirdContactEmail { get; set; }
        public string? ThirdContactRelationship { get; set; }
        public DateTimeOffset? RecordSubmissionDateTime { get; set; }
        public string? WhoSubmitted { get; set; }

        public virtual Institution? Institution { get; set; }
        public virtual ICollection<MissingReport> MissingReports { get; set; }
    }
}
