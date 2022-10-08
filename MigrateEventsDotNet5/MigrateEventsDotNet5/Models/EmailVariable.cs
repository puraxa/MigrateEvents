using System;
using System.Collections.Generic;

namespace MigrateEvents.Models
{
    public partial class EmailVariable
    {
        public int VariableId { get; set; }
        public string Name { get; set; } = null!;
        public string VarDescription { get; set; } = null!;
        public bool? IsGeneral { get; set; }
        public bool? IsTt { get; set; }
        public bool? IsCmletter { get; set; }
        public bool? IsIr { get; set; }
        public bool? IsCm { get; set; }
        public bool? IsAo { get; set; }
        public bool? IsCl { get; set; }
    }
}
