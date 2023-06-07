using System;
using System.Collections.Generic;

namespace EsdAcl_API.Models.engineer
{
    public partial class AclCardNew
    {
        public string CardId { get; set; } = null!;
        public string EmpNo { get; set; } = null!;
        public string? EmpName { get; set; }
        public string? DeptCode { get; set; }
        public string? DeptName { get; set; }
        public string? Position { get; set; }
        public string? UpdateFlag { get; set; }
        public string? FrontNo { get; set; }
        public string? BackNo { get; set; }
        public string? UpdateBy { get; set; }
        public DateTime? LastUpdate { get; set; }
        public string? LastRemark { get; set; }
        public string? Handicap { get; set; }
        public string? CardSts { get; set; }
        public string? CardType { get; set; }
        public DateTime? AclCardActdate { get; set; }
    }
}
