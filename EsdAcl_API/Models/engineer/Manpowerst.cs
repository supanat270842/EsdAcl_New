using System;
using System.Collections.Generic;

namespace EsdAcl_API.Models.engineer
{
    public partial class Manpowerst
    {
        public int Id { get; set; }
        public string? Line { get; set; }
        public string? Description { get; set; }
        public string PartNumber { get; set; } = null!;
        public decimal? St { get; set; }
    }
}
