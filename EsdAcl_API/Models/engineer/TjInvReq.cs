using System;
using System.Collections.Generic;

namespace EsdAcl_API.Models.engineer
{
    public partial class TjInvReq
    {
        public string RequestId { get; set; } = null!;
        public string EmpReq { get; set; } = null!;
        public string ProdId { get; set; } = null!;
        public string LineId { get; set; } = null!;
        public string? StationId { get; set; }
        public string CatId { get; set; } = null!;
        public string CatDetailId { get; set; } = null!;
        public string? RequestDetail { get; set; }
        public DateTime? CompleteDate { get; set; }
        public string? Status { get; set; }
        public string? ProbleSolveDesc { get; set; }
        public string? MsgToUser { get; set; }
        public DateTime? RequestDate { get; set; }
        public string? ReqPriorityId { get; set; }
        public string? AssignByEmpNo { get; set; }
        public string? AssignBy { get; set; }
        public DateTime? AssignDate { get; set; }
    }
}
