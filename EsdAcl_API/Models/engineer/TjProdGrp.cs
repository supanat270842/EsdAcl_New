using System;
using System.Collections.Generic;

namespace EsdAcl_API.Models.engineer
{
    public partial class TjProdGrp
    {
        public string ProdId { get; set; } = null!;
        public string ProdName { get; set; } = null!;
        public string? ProdStatus { get; set; }
        public string? UpdateBy { get; set; }
        public DateTime? UpdateDate { get; set; }
    }
}
