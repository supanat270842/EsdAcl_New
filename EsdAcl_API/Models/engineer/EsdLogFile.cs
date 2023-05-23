using System;
using System.Collections.Generic;

namespace EsdAcl_API.Models.engineer
{
    public partial class EsdLogFile
    {
        public decimal? Id { get; set; }
        public string? Filename { get; set; }
        public DateTime? CreateDate { get; set; }
        public string? Status { get; set; }
        public string? Items { get; set; }
        public string? FileCreateDate { get; set; }
    }
}
