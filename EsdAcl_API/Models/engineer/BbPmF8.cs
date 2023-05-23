using System;
using System.Collections.Generic;

namespace EsdAcl_API.Models.engineer
{
    public partial class BbPmF8
    {
        public string PmF8Id { get; set; } = null!;
        public string PmId { get; set; } = null!;
        public string NumEqm { get; set; } = null!;
        public string? PmDesc { get; set; }
        public string? ModelEffect { get; set; }
        public string? Cleaning { get; set; }
        public string? Lubricant { get; set; }
        public string? Vtos { get; set; }
        public string? VqosS { get; set; }
        public string? VqosA { get; set; }
        public string? Vcatrf { get; set; }
        public string? Vsotps { get; set; }
        public string? Vclat { get; set; }
        public string? Vatfoc { get; set; }
        public string? VttcS { get; set; }
        public string? VttcA { get; set; }
        public string? Vtw { get; set; }
        public string? Vci { get; set; }
        public string? SpecS { get; set; }
        public string? SpecA { get; set; }
        public string? SpecRs { get; set; }
        public string? Snl { get; set; }
        public string? LocLy { get; set; }
        public string? LocGr { get; set; }
        public string? RpmTf { get; set; }
        public string? RpmRfu { get; set; }
        public string? RpmCantu { get; set; }
        public string? Gverify { get; set; }
        public string? Remark { get; set; }
        public string? CvqtahsSpec { get; set; }
        public string? CvqtahsActual { get; set; }
    }
}
