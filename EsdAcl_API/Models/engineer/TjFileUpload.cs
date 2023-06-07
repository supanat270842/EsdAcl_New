using System;
using System.Collections.Generic;

namespace EsdAcl_API.Models.engineer
{
    public partial class TjFileUpload
    {
        public string FileId { get; set; } = null!;
        public string? FileName { get; set; }
        public string? FileContentType { get; set; }
        public string? FileSize { get; set; }
    }
}
