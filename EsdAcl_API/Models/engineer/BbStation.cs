using System;
using System.Collections.Generic;

namespace EsdAcl_API.Models.engineer
{
    public partial class BbStation
    {
        public string StationId { get; set; } = null!;
        public string ProdId { get; set; } = null!;
        public string LineId { get; set; } = null!;
        public string StationName { get; set; } = null!;
        public string? StationStatus { get; set; }
        public string? UpdateBy { get; set; }
        public DateTime? UpdateDate { get; set; }
    }
}
