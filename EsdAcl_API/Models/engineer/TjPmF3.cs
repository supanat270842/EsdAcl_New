using System;
using System.Collections.Generic;

namespace EsdAcl_API.Models.engineer
{
    public partial class TjPmF3
    {
        public string PmF3Id { get; set; } = null!;
        public string PmId { get; set; } = null!;
        public string NumEqm { get; set; } = null!;
        public string? PmDesc { get; set; }
        public string? ModelEffect { get; set; }
        public string? Spec { get; set; }
        public string? Actual { get; set; }
        public string? Result { get; set; }
        public string? Gverify { get; set; }
        public string? Remark { get; set; }
    }
}
