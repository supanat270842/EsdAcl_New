using System;
using System.Collections.Generic;

namespace EsdAcl_API.Models.engineer
{
    public partial class BbWorkTime
    {
        public string TimeId { get; set; } = null!;
        public string? TimeDesc { get; set; }
        public string? TimeStatus { get; set; }
        public string? UpdateBy { get; set; }
        public DateTime? UpdateDate { get; set; }
    }
}
