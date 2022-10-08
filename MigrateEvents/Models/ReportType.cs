﻿using System;
using System.Collections.Generic;

namespace MigrateEvents.Models
{
    public partial class ReportType
    {
        public ReportType()
        {
            Reports = new HashSet<Report>();
        }

        public int ReportTypeId { get; set; }
        public string Name { get; set; } = null!;

        public virtual ICollection<Report> Reports { get; set; }
    }
}
