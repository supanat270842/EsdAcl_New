using System;
using System.Collections.Generic;

namespace EsdAcl_API.Models.engineer
{
    public partial class TjWbAnswer
    {
        public string AnsId { get; set; } = null!;
        public string QId { get; set; } = null!;
        public string? Answer { get; set; }
        public string? FileId { get; set; }
        public DateTime? AnsDate { get; set; }
        public string AnsLoginName { get; set; } = null!;
    }
}
