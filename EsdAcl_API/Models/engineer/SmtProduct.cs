using System;
using System.Collections.Generic;

namespace EsdAcl_API.Models.engineer
{
    public partial class SmtProduct
    {
        public decimal ProductId { get; set; }
        public string? ProductPn { get; set; }
        public string? ProductName { get; set; }
        public string? Customer { get; set; }
        public string? Revision { get; set; }
        public string? Stencil1 { get; set; }
        public string? Stencil2 { get; set; }
        public string? Stencil3 { get; set; }
        public string? Stencil4 { get; set; }
        public string? Profile1 { get; set; }
        public string? Profile2 { get; set; }
    }
}
