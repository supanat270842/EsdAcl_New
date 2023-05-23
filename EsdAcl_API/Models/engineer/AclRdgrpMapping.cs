using System;
using System.Collections.Generic;

namespace EsdAcl_API.Models.engineer
{
    public partial class AclRdgrpMapping
    {
        public string AclRdgrpMapId { get; set; } = null!;
        public string? AclRdgrpCode { get; set; }
        public string? CardId { get; set; }
    }
}
