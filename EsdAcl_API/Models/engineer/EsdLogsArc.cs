﻿using System;
using System.Collections.Generic;

namespace EsdAcl_API.Models.engineer
{
    public partial class EsdLogsArc
    {
        public string? EmpNo { get; set; }
        public DateTime? EntryDate { get; set; }
        public string? EsdWrist { get; set; }
        public string? EsdShoe { get; set; }
        public string? SourceName { get; set; }
        public string? SiteId { get; set; }
        public string? CardMscan { get; set; }
        public string? CardCscan { get; set; }
        public string? RandomCheck { get; set; }
        public string? GateType { get; set; }
        public string? Building { get; set; }
        public string? ReaderType { get; set; }
        public DateTime? ExitDate { get; set; }
        public DateTime? LogDate { get; set; }
    }
}
