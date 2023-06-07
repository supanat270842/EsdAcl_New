using System;
using System.Collections.Generic;

namespace EsdAcl_API.Models.engineer
{
    public partial class TjImg
    {
        public string ImgId { get; set; } = null!;
        public string? ImgName { get; set; }
        public string? ImgDesc { get; set; }
        public string? UpdateBy { get; set; }
        public DateTime? UpdateDate { get; set; }
        public string? ImgStatus { get; set; }
        public string? ImgDefault { get; set; }
    }
}
