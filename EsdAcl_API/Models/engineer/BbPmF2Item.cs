using System;
using System.Collections.Generic;

namespace EsdAcl_API.Models.engineer
{
    public partial class BbPmF2Item
    {
        public string PmId { get; set; } = null!;
        public string Section { get; set; } = null!;
        public string ItemType { get; set; } = null!;
        public string VoltType { get; set; } = null!;
        public string? Fan1 { get; set; }
        public string? Fan2 { get; set; }
        public string? Fan3 { get; set; }
        public string? Result { get; set; }
    }
}
