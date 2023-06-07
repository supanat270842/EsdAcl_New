using System;
using System.Collections.Generic;

namespace EsdAcl_API.Models.engineer
{
    public partial class TjPmF6
    {
        public string PmF6Id { get; set; } = null!;
        public string PmId { get; set; } = null!;
        public string NumEqm { get; set; } = null!;
        public string? PmDesc { get; set; }
        public string? ModelEffect { get; set; }
        public string? Vfmi { get; set; }
        public string? Vfpi { get; set; }
        public string? Vfbti { get; set; }
        public string? Cwv { get; set; }
        public string? Gv { get; set; }
        public string? Gverify { get; set; }
        public string? Remark { get; set; }
    }
}
