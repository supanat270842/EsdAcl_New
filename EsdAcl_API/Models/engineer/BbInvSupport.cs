using System;
using System.Collections.Generic;

namespace EsdAcl_API.Models.engineer
{
    public partial class BbInvSupport
    {
        public string SupportId { get; set; } = null!;
        public string RequestId { get; set; } = null!;
        public string? AssignToEmpNo { get; set; }
        public string AssignTo { get; set; } = null!;
        public string? Remark { get; set; }
        public DateTime? WorkStart { get; set; }
        public DateTime? WorkEnd { get; set; }
        public string? RootJob { get; set; }
        public string? SupportStatus { get; set; }
        public string? CallBackMsg { get; set; }
    }
}
