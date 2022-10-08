using System;
using System.Collections.Generic;

namespace MigrateEvents.Models
{
    public partial class State
    {
        public State()
        {
            EmergencyContacts = new HashSet<EmergencyContact>();
            Institutions = new HashSet<Institution>();
        }

        public string StateAbr { get; set; } = null!;
        public string Name { get; set; } = null!;

        public virtual ICollection<EmergencyContact> EmergencyContacts { get; set; }
        public virtual ICollection<Institution> Institutions { get; set; }
    }
}
