using System;
using System.Collections.Generic;

namespace EsdAcl_API.Models.engineer
{
    public partial class TjLine
    {
        public string LineId { get; set; } = null!;
        public string ProdId { get; set; } = null!;
        public string LineName { get; set; } = null!;
        public string? LineStatus { get; set; }
        public string? UpdateBy { get; set; }
        public DateTime? UpdateDate { get; set; }
    }
}
