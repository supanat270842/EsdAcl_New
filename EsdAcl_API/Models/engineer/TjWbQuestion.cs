using System;
using System.Collections.Generic;

namespace EsdAcl_API.Models.engineer
{
    public partial class TjWbQuestion
    {
        public string QId { get; set; } = null!;
        public string QcatId { get; set; } = null!;
        public string? FromShiftId { get; set; }
        public string? ToShiftId { get; set; }
        public string? Qtopic { get; set; }
        public string? Qdetail { get; set; }
        public decimal? Qreader { get; set; }
        public decimal? Qanswer { get; set; }
        public string? FileId { get; set; }
        public DateTime? Qdate { get; set; }
        public string QloginName { get; set; } = null!;
    }
}
