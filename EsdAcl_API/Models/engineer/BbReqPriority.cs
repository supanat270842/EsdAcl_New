using System;
using System.Collections.Generic;

namespace EsdAcl_API.Models.engineer
{
    public partial class BbReqPriority
    {
        public string ReqPriorityId { get; set; } = null!;
        public string ReqPriorityCode { get; set; } = null!;
        public string? ReqPriorityDesc { get; set; }
        public string? ReqPriorityStatus { get; set; }
        public string? UpdateBy { get; set; }
        public DateTime? UpdateDate { get; set; }
    }
}
