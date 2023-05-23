using System;
using System.Collections.Generic;

namespace EsdAcl_API.Models.engineer
{
    public partial class BbPmF1
    {
        public string PmF1Id { get; set; } = null!;
        public string PmId { get; set; } = null!;
        public string ScrewNo { get; set; } = null!;
        public string? Sn { get; set; }
        public string? Torque1 { get; set; }
        public string? Torque2 { get; set; }
        public string? BitType { get; set; }
        public string? BitCheck { get; set; }
        public string? Ceaning { get; set; }
        public string? BfCalibrate { get; set; }
        public string? ActTorque1 { get; set; }
        public string? ActTorque2 { get; set; }
        public string? ActTorque3 { get; set; }
        public string? ActTorqueAvg { get; set; }
        public string? Result { get; set; }
        public string? Remark { get; set; }
    }
}
