using System;
using System.Collections.Generic;

namespace EsdAcl_API.Models.engineer
{
    public partial class BbPmF2Hearder
    {
        public string PmId { get; set; } = null!;
        public string? Sn { get; set; }
        public string? AirLonizerType { get; set; }
        public string? Chk1LightSts { get; set; }
        public string? Chk2LightSts { get; set; }
        public string? Distance1 { get; set; }
        public string? Distance2 { get; set; }
        public string? Distance3 { get; set; }
        public string? Conclusion { get; set; }
        public string? ConclusionDesc { get; set; }
        public string? Action { get; set; }
        public string? Remark { get; set; }
    }
}
