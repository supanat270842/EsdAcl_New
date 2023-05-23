using System;
using System.Collections.Generic;

namespace EsdAcl_API.Models.engineer
{
    public partial class AclLog
    {
        public string AclLogId { get; set; } = null!;
        public string? AclCardId { get; set; }
        public string? AclCardType { get; set; }
        public string? FrontNo { get; set; }
        public string? BackNo { get; set; }
        public string? Handicap { get; set; }
        public string? EmpNo { get; set; }
        public string? EmpName { get; set; }
        public string? DeptCode { get; set; }
        public string? DeptName { get; set; }
        public string? Position { get; set; }
        public string? AclLogRemark { get; set; }
        public string? UpdateBy { get; set; }
        public DateTime? UpdateDate { get; set; }
        public string? LastRemark { get; set; }
        public string? Description { get; set; }
    }
}
