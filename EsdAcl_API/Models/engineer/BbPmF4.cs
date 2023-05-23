using System;
using System.Collections.Generic;

namespace EsdAcl_API.Models.engineer
{
    public partial class BbPmF4
    {
        public string PmF4Id { get; set; } = null!;
        public string PmId { get; set; } = null!;
        public string NumEqm { get; set; } = null!;
        public string? PmDesc { get; set; }
        public string? ModelEffect { get; set; }
        public string? CocPreFilter { get; set; }
        public string? ClrMachine { get; set; }
        public string? GnrCheck { get; set; }
        public string? CapActual { get; set; }
        public string? CapResult { get; set; }
        public string? Gverify { get; set; }
        public string? Remark { get; set; }
    }
}
