using System;
using System.Collections.Generic;

namespace MigrateEvents.Models
{
    public partial class Region
    {
        public Region()
        {
            Countries = new HashSet<Country>();
        }

        public int RegionId { get; set; }
        public string Name { get; set; } = null!;

        public virtual ICollection<Country> Countries { get; set; }
    }
}
