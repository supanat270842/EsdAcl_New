using System;
using System.Collections.Generic;

namespace EsdAcl_API.Models.engineer
{
    public partial class AclTranType
    {
        public string AclTrantypeId { get; set; } = null!;
        public string? AclTypeDesc { get; set; }
        public string? AclTypeSts { get; set; }
    }
}
