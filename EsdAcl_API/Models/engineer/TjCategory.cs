using System;
using System.Collections.Generic;

namespace EsdAcl_API.Models.engineer
{
    public partial class TjCategory
    {
        public string CatId { get; set; } = null!;
        public string CatName { get; set; } = null!;
        public string? CatStatus { get; set; }
        public string? UpdateBy { get; set; }
        public DateTime? UpdateDate { get; set; }
    }
}
