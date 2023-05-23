using System;
using System.Collections.Generic;

namespace EsdAcl_API.Models.engineer
{
    public partial class TjMdEff
    {
        public string MdEffId { get; set; } = null!;
        public string? MdEff { get; set; }
        public string? UpdateBy { get; set; }
        public DateTime? UpdateDate { get; set; }
    }
}
