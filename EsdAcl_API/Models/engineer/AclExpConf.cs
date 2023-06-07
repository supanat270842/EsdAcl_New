using System;
using System.Collections.Generic;

namespace EsdAcl_API.Models.engineer
{
    public partial class AclExpConf
    {
        public string AclexpId { get; set; } = null!;
        public string ClientName { get; set; } = null!;
        public string AclexpPath { get; set; } = null!;
        public DateTime? AclexpLastUpdate { get; set; }
        public string? AclexpEmail { get; set; }
        public string? AclexpSts { get; set; }
        public string? Building { get; set; }
        public string? GateType { get; set; }
        public string? AclTrantypeId { get; set; }
        public string? MapdriveUser { get; set; }
        public string? MapdrivePass { get; set; }
        public string? ReaderType { get; set; }
    }
}
