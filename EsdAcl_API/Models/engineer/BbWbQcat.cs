using System;
using System.Collections.Generic;

namespace EsdAcl_API.Models.engineer
{
    public partial class BbWbQcat
    {
        public string QcatId { get; set; } = null!;
        public string? QcatDesc { get; set; }
        public string? QcatStatus { get; set; }
        public string? UpdateBy { get; set; }
        public DateTime? UpdateDate { get; set; }
    }
}
