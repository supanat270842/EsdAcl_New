using System;
using System.Collections.Generic;

namespace EsdAcl_API.Models.engineer
{
    public partial class EsdEmpLeave
    {
        public string SiteId { get; set; } = null!;
        public string LeaveId { get; set; } = null!;
        public string? EmpNo { get; set; }
        public string? LeaveCode { get; set; }
        public DateTime? FromDate { get; set; }
        public DateTime? ToDate { get; set; }
        public string? Remark { get; set; }
    }
}
