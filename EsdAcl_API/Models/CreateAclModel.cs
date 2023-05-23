using Dapper;
using Microsoft.AspNetCore.Mvc;
using Oracle.ManagedDataAccess.Client;
using System.Text;

namespace EsdAcl_API.Models
{
    public class CreateAclModel
    {
        public string? CARD_ID { get; set; }
        public string? EMP_NO { get; set; }
        public string? EMP_NAME { get; set; }
        public string? DEPT_CODE { get; set; }
        public string? DEPT_NAME { get; set; }
        public string? POSITION { get; set; }
        public string? UPDATE_FLAG { get; set; }
        public string? FRONT_NO { get; set; }
        public string? BACK_NO { get; set; }
        public string? UPDATE_BY { get; set; }
        public string? LAST_REMARK { get; set; }
        public string? HANDICAP { get; set; }
        public string? CARD_STS { get; set; }
        public string? CARD_TYPE { get; set; }

    }
    public class CreateAclModelPost
    {
        public string? CARD_ID { get; set; }
        public string? EMP_NO { get; set; }
        public string? EMP_NAME { get; set; }
        public string? DEPT_CODE { get; set; }
        public string? DEPT_NAME { get; set; }
        public string? POSITION { get; set; }
        public string? UPDATE_FLAG { get; set; }
        public string? FRONT_NO { get; set; }
        public string? BACK_NO { get; set; }
        public string? UPDATE_BY { get; set; }
        public DateTime? LAST_UPDATE { get; set; }
        public string? LAST_REMARK { get; set; }
        public string? HANDICAP { get; set; }
        public string? CARD_STS { get; set; }
        public string? CARD_TYPE { get; set; }
        public DateTime? ACL_CARD_ACTDATE { get; set; }

    }

    public class CreateAclModel_Resposity
    {
        public List<CreateAclModelPost> CreateACL(CreateAclModel data)
        {
            string cardID = data.CARD_ID;
            string empNo = data.EMP_NO;
            string empName = data.EMP_NAME;
            string deptCode = data.DEPT_CODE;
            string deptName = data.DEPT_NAME;
            string position = data.POSITION;
            string updateFlag = data.UPDATE_FLAG;
            string cardType = data.CARD_TYPE;
            string frontNo = data.FRONT_NO;
            string backNo = data.BACK_NO;
            string updateBy = data.UPDATE_BY;
            string lastUpdate = DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss");
            string handicap = data.HANDICAP;
            string cardSts = data.CARD_STS;
            string lastRemark = data.LAST_REMARK;
            string aclCardAct = DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss");

            try
            {
                string str = "Data Source=(DESCRIPTION=(ADDRESS_LIST=(ADDRESS=(PROTOCOL=TCP)(HOST= cthorap21.th-lcb.celestica.com)(PORT=1521)))(CONNECT_DATA=(SERVER=DEDICATED)(SERVICE_NAME=appstest))); User ID=robin;Password=pcjaws5t;";

                using (OracleConnection conn = new OracleConnection(str))
                {
                    string sql = @"
                                  Insert Into Engineer.ACL_CARD (CARD_ID,EMP_NO,EMP_NAME,DEPT_CODE,DEPT_NAME,POSITION
                                  ,UPDATE_FLAG,FRONT_NO,BACK_NO,UPDATE_BY,LAST_UPDATE,LAST_REMARK,HANDICAP,CARD_TYPE 
                                  ,CARD_STS,ACL_CARD_ACTDATE) 
                                  ";

                    StringBuilder sb = new StringBuilder();

                    sb.AppendLine("Values ( ");

                    sb.Append($"'{cardID}'");
                    sb.Append($",'{empNo}'");
                    sb.Append($",'{empName}'");
                    sb.Append($",'{deptCode}'");
                    sb.Append($",'{deptName}'");
                    sb.Append($",'{position}'");
                    sb.Append($",'{updateFlag}'");
                    sb.Append($",'{frontNo}'");
                    sb.Append($",'{backNo}'");
                    sb.Append($",'{updateBy}'");
                    sb.Append($",to_date('{lastUpdate}','dd/MM/yyyy HH24:MI:SS')");
                    sb.Append($",'{lastRemark}'");
                    sb.Append($",'{handicap}'");
                    sb.Append($",'{cardType}'");
                    sb.Append($",'{cardSts}'");
                    sb.Append($",to_date('{aclCardAct}','dd/MM/yyyy HH24:MI:SS')");
                    sb.Append(") ");

                    string merge_sql = sql + sb.ToString(); 
                    
                    conn.Execute(merge_sql);

                    string queryDB = $"select * from Engineer.ACL_CARD Where CARD_ID = '{cardID}'";

                    return conn.Query<CreateAclModelPost>(queryDB).ToList();

                }
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }
    }


}
