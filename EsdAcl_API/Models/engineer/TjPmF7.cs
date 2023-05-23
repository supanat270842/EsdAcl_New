using System;
using System.Collections.Generic;

namespace EsdAcl_API.Models.engineer
{
    public partial class TjPmF7
    {
        public string PmF7Id { get; set; } = null!;
        public string PmId { get; set; } = null!;
        public string NumEqm { get; set; } = null!;
        public string? PmDesc { get; set; }
        public string? ModelEffect { get; set; }
        public string? Vact { get; set; }
        public string? Vttgrm { get; set; }
        public string? VttgrmRs { get; set; }
        public string? Vttgpm { get; set; }
        public string? VttgpmRs { get; set; }
        public string? Vttgcm { get; set; }
        public string? VttgcmRs { get; set; }
        public string? Vacmb { get; set; }
        public string? TestRun { get; set; }
        public string? Gverify { get; set; }
        public string? Remark { get; set; }
    }
}
