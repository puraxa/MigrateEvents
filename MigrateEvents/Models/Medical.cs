using System;
using System.Collections.Generic;

namespace MigrateEvents.Models
{
    public partial class Medical
    {
        public Medical()
        {
            Allergies = new HashSet<Allergy>();
            Immunizations = new HashSet<Immunization>();
            Medications = new HashSet<Medication>();
            PreExisitings = new HashSet<PreExisiting>();
        }

        public int MedicalId { get; set; }
        public string? BloodType { get; set; }
        public string? Comments { get; set; }
        public int UserId { get; set; }

        public virtual User User { get; set; } = null!;
        public virtual ICollection<Allergy> Allergies { get; set; }
        public virtual ICollection<Immunization> Immunizations { get; set; }
        public virtual ICollection<Medication> Medications { get; set; }
        public virtual ICollection<PreExisiting> PreExisitings { get; set; }
    }
}
