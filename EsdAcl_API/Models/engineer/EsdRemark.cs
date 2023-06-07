using System;
using System.Collections.Generic;

namespace EsdAcl_API.Models.engineer
{
    public partial class EsdRemark
    {
        public string EsdRemarkId { get; set; } = null!;
        public string? EsdRemarkDesc { get; set; }
        public string? EsdRemarkSts { get; set; }
    }
}
