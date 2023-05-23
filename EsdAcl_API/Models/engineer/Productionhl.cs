using System;
using System.Collections.Generic;

namespace EsdAcl_API.Models.engineer
{
    public partial class Productionhl
    {
        public int No { get; set; }
        public string? Owner { get; set; }
        public string? Filename { get; set; }
        public DateTime? Ddate { get; set; }
        public string? Type { get; set; }
    }
}
