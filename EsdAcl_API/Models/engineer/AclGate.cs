using System;
using System.Collections.Generic;

namespace EsdAcl_API.Models.engineer
{
    public partial class AclGate
    {
        public string AclGateId { get; set; } = null!;
        public string? AclReaderInfo { get; set; }
        public string? AclGateInfo { get; set; }
        public string? AclSts { get; set; }
    }
}
