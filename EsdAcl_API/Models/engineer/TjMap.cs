using System;
using System.Collections.Generic;

namespace EsdAcl_API.Models.engineer
{
    public partial class TjMap
    {
        public string MapId { get; set; } = null!;
        public string? ImgId { get; set; }
        public string? ProdId { get; set; }
        public string? LineId { get; set; }
        public string? StationId { get; set; }
        public string? Url { get; set; }
        public string? UpdateBy { get; set; }
        public DateTime? UpdateDate { get; set; }
        public string X1 { get; set; } = null!;
        public string Y1 { get; set; } = null!;
        public string X2 { get; set; } = null!;
        public string Y2 { get; set; } = null!;
        public string Width { get; set; } = null!;
        public string Height { get; set; } = null!;
        public string? Text { get; set; }
        public string? Border { get; set; }
    }
}
