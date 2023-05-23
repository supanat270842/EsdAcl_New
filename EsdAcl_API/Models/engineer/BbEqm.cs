using System;
using System.Collections.Generic;

namespace EsdAcl_API.Models.engineer
{
    public partial class BbEqm
    {
        public string EqmId { get; set; } = null!;
        public string EqmName { get; set; } = null!;
        public string EqmStatus { get; set; } = null!;
        public string? UpdateBy { get; set; }
        public DateTime? UpdateDate { get; set; }
    }
}
