using System;
using System.Collections.Generic;

namespace EsdAcl_API.Models.engineer
{
    public partial class EsdGofSt
    {
        public string GofId { get; set; } = null!;
        public string? GofName { get; set; }
        public string? ClientName { get; set; }
        public DateTime? GofImpDate { get; set; }
        public DateTime? GofDate { get; set; }
        public string? GofSts { get; set; }
        public string? GofPath { get; set; }
        public string? GofMsgLog { get; set; }
    }
}
