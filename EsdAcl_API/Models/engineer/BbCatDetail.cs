using System;
using System.Collections.Generic;

namespace EsdAcl_API.Models.engineer
{
    public partial class BbCatDetail
    {
        public string CatDetailId { get; set; } = null!;
        public string CatId { get; set; } = null!;
        public string? ProblemCode { get; set; }
        public string? ProblemDetail { get; set; }
        public string? ProblemStatus { get; set; }
        public string? UpdateBy { get; set; }
        public DateTime? UpdateDate { get; set; }
        public string? ReqPriorityId { get; set; }
    }
}
