using System;
using System.Collections.Generic;

namespace EsdAcl_API.Models.engineer
{
    public partial class EsdEmpTmplistNew
    {
        public string SiteId { get; set; } = null!;
        public string EmpNo { get; set; } = null!;
        public string? DeptCode { get; set; }
        public string? Building { get; set; }
        public string? SupsiteId { get; set; }
        public string? SupempNo { get; set; }
        public string? PrepareBy { get; set; }
        public DateTime? PrepareDate { get; set; }
        public string? ApproveBy { get; set; }
        public DateTime? ApproveDate { get; set; }
        public string? ApproveId { get; set; }
        public string? StsProcess { get; set; }
        public string? StsLoad { get; set; }
    }
}
