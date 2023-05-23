using System;
using System.Collections.Generic;

namespace EsdAcl_API.Models.engineer
{
    public partial class TjEqmType
    {
        public string EqmTypeId { get; set; } = null!;
        public string EqmId { get; set; } = null!;
        public string EqmTypeName { get; set; } = null!;
        public string EqmTypeStatus { get; set; } = null!;
        public string? UpdateBy { get; set; }
        public DateTime? UpdateDate { get; set; }
        public string? EqmPmForm { get; set; }
    }
}
