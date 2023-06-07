using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;

namespace EsdAcl_New.Models
{
    public class CreateAclModel
    {
        public string cardId { get; set; }
        public string empNo { get; set; }
        public string empName { get; set; }
        public string deptCode { get; set; }
        public string deptName { get; set; }
        public string position { get; set; }
        public string updateFlag { get; set; }
        public string frontNo { get; set; }
        public string backNo { get; set; }
        public string updateBy { get; set; }
        public DateTime lastUpdate { get; set; }
        public string lastRemark { get; set; }
        public string handicap { get; set; }
        public string cardSts { get; set; }
        public string cardType { get; set; }
        public DateTime aclCardActdate { get; set; }
    }
    public class CreateAclModel1
    {
        public string cardId { get; set; }
        public string empNo { get; set; }
        public string empName { get; set; }
        public string deptCode { get; set; }
        public string deptName { get; set; }
        public string position { get; set; }
        public string updateFlag { get; set; }
        public string frontNo { get; set; }
        public string backNo { get; set; }
        public string updateBy { get; set; }
        public DateTime lastUpdate { get; set; }
        public string lastRemark { get; set; }
        public string handicap { get; set; }
        public string cardSts { get; set; }
        public string cardType { get; set; }
        public DateTime aclCardActdate { get; set; }
    }

}
