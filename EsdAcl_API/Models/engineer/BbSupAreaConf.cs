using System;
using System.Collections.Generic;

namespace EsdAcl_API.Models.engineer
{
    public partial class BbSupAreaConf
    {
        public string ProdId { get; set; } = null!;
        public string LoginName { get; set; } = null!;
        public string? UpdateBy { get; set; }
        public DateTime? UpdateDate { get; set; }
    }
}
