using System;
using System.Collections.Generic;

namespace EsdAcl_API.Models.engineer
{
    public partial class AclRdgrp
    {
        public string AclRdgrpId { get; set; } = null!;
        public string AclRdgrpCode { get; set; } = null!;
        public string? AclRdgrpDesc { get; set; }
        public string? AclRdgrpSts { get; set; }
        public string? UpdateBy { get; set; }
        public DateTime? UpdateDate { get; set; }
    }
}
