using System;
using System.Collections.Generic;

namespace EsdAcl_API.Models.engineer
{
    public partial class BbMsgToUser
    {
        public string BbMsgId { get; set; } = null!;
        public string RequestId { get; set; } = null!;
        public string SupportId { get; set; } = null!;
        public string MsgBy { get; set; } = null!;
        public string MsgToUser { get; set; } = null!;
        public DateTime? MsgDate { get; set; }
    }
}
