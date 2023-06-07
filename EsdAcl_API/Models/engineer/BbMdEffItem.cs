using System;
using System.Collections.Generic;

namespace EsdAcl_API.Models.engineer
{
    public partial class BbMdEffItem
    {
        public string MdEffItemId { get; set; } = null!;
        public string MdEffId { get; set; } = null!;
        public string? NumEqm { get; set; }
        public string? NumEqmDesc { get; set; }
        public string? UpdateBy { get; set; }
        public DateTime? UpdateDate { get; set; }
    }
}
