using System;
using System.Collections.Generic;

namespace EsdAcl_API.Models.engineer
{
    public partial class BbPmF5
    {
        public string PmF5Id { get; set; } = null!;
        public string PmId { get; set; } = null!;
        public string NumEqm { get; set; } = null!;
        public string? PmDesc { get; set; }
        public string? ModelEffect { get; set; }
        public string? Vsot { get; set; }
        public string? CwcsIpa { get; set; }
        public string? Cwu { get; set; }
        public string? Cbag { get; set; }
        public string? Gverify { get; set; }
        public string? Remark { get; set; }
    }
}
