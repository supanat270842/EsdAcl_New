using System;
using System.Collections.Generic;

namespace EsdAcl_API.Models.engineer
{
    public partial class TjPmScheduled
    {
        public string PmId { get; set; } = null!;
        public string? ProdId { get; set; }
        public string? LineId { get; set; }
        public string? StationId { get; set; }
        public string EqmId { get; set; } = null!;
        public string EqmTypeId { get; set; } = null!;
        public DateTime PmDate { get; set; }
        public string PmType { get; set; } = null!;
        public string? PmDesc { get; set; }
        public string? PmStatus { get; set; }
        public string? UpdateBy { get; set; }
        public DateTime? UpdateDate { get; set; }
        public string? SupportBy { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? CompleteDate { get; set; }
    }
}
