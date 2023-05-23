using System;
using System.Collections.Generic;

namespace EsdAcl_API.Models.engineer
{
    public partial class SmtStencil
    {
        public decimal StencilId { get; set; }
        public string? StencilSn { get; set; }
        public string? Slot { get; set; }
        public string? Side { get; set; }
        public string? Iri { get; set; }
        public DateTime? ReceiveDate { get; set; }
        public string? PrintProgram { get; set; }
        public string? ImageType { get; set; }
        public string? A { get; set; }
        public string? B { get; set; }
        public string? Assigned { get; set; }
        public string? StencilModify { get; set; }
        public string? Remark { get; set; }
    }
}
