using System;
using System.Collections.Generic;

namespace EsdAcl_API.Models.engineer
{
    public partial class TjArea
    {
        public string AreaId { get; set; } = null!;
        public string? AreaDesc { get; set; }
        public string? AreaStatus { get; set; }
        public string? UpdateBy { get; set; }
        public DateTime? UpdateDate { get; set; }
    }
}
