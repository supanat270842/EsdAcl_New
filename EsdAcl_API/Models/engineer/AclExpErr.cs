using System;
using System.Collections.Generic;

namespace EsdAcl_API.Models.engineer
{
    public partial class AclExpErr
    {
        public string AclexpErrId { get; set; } = null!;
        public string? AclexpErrDesc { get; set; }
        public DateTime? AclexpErrDate { get; set; }
        public string? AclexpId { get; set; }
        public string? ClientName { get; set; }
    }
}
