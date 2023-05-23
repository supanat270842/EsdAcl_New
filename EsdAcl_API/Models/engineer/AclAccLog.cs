using System;
using System.Collections.Generic;

namespace EsdAcl_API.Models.engineer
{
    public partial class AclAccLog
    {
        public string AclAccId { get; set; } = null!;
        public string? CardId { get; set; }
        public string? FrontNo { get; set; }
        public string? BackNo { get; set; }
        public string? AclGateId { get; set; }
        public DateTime? AccDate { get; set; }
        public string? AccEmpNo { get; set; }
        public string? AccBy { get; set; }
        public string? AccInfo { get; set; }
    }
}
