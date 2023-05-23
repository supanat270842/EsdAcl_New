using Dapper;
using Microsoft.AspNetCore.Mvc;
using Oracle.ManagedDataAccess.Client;
using System.Text;

namespace EsdAcl_API.Models
{
    public class EditAclModel
    {
        public string CARD_ID { get; set; }
        public string? EMP_NO { get; set; }
        public string? EMP_NAME { get; set; }
        public string? DEPT_CODE { get; set; }
        public string? DEPT_NAME { get; set; }
        public string? POSITION { get; set; }
        public string? UPDATE_FLAG { get; set; }
        public string? CARD_TYPE { get; set; }
        public string? FRONT_NO { get; set; }
        public string? BACK_NO { get; set; }
        public string? UPDATE_BY { get; set; }
        public string? HANDICAP { get; set; }
        public string? CARD_STS { get; set; }
        public string? LAST_REMARK { get; set; }

    }

    public class Acl_CardModel
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

    public class EditAclModel_Resposity
    {
        public List<Acl_CardModel> EditEsdAcl(EditAclModel editAclModel)
        {

            string cardID = editAclModel.CARD_ID;
            string empNo = editAclModel.EMP_NO;
            string empName = editAclModel.EMP_NAME;
            string deptCode = editAclModel.DEPT_CODE;
            string deptName = editAclModel.DEPT_NAME;
            string position = editAclModel.POSITION;
            string updateFlag = editAclModel.UPDATE_FLAG;
            string cardType = editAclModel.CARD_TYPE;
            string frontNo = editAclModel.FRONT_NO;
            string backNo = editAclModel.BACK_NO;
            string updateBy = editAclModel.UPDATE_BY;
            string lastUpdate = DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss");
            string handicap = editAclModel.HANDICAP;
            string cardSts = editAclModel.CARD_STS;
            string lastRemark = editAclModel.LAST_REMARK;
            string cardIdEdit = frontNo + backNo;


            try
            {
                string str = "Data Source=(DESCRIPTION=(ADDRESS_LIST=(ADDRESS=(PROTOCOL=TCP)(HOST= cthorap21.th-lcb.celestica.com)(PORT=1521)))(CONNECT_DATA=(SERVER=DEDICATED)(SERVICE_NAME=appstest))); User ID=robin;Password=pcjaws5t;";

                using (OracleConnection conn = new OracleConnection(str))
                {
                    StringBuilder sb = new StringBuilder();

                    sb.AppendLine("Update Engineer.ACL_CARD Set ");

                    if (!String.IsNullOrEmpty(empNo))
                    {
                        sb.AppendLine($"EMP_NO = '{empNo}'");
                    }
                    if (!String.IsNullOrEmpty(cardIdEdit))
                    {
                        sb.AppendLine($",CARD_ID = '{cardIdEdit}'");
                    }
                    if (!String.IsNullOrEmpty(empName))
                    {
                        sb.AppendLine($",EMP_NAME = '{empName}'");
                    }
                    if (!String.IsNullOrEmpty(deptCode))
                    {
                        sb.AppendLine($",DEPT_CODE = '{deptCode}'");
                    }
                    if (!String.IsNullOrEmpty(deptName))
                    {
                        sb.AppendLine($",DEPT_NAME = '{deptName}'");
                    }
                    if (!String.IsNullOrEmpty(position))
                    {
                        sb.AppendLine($",POSITION = '{position}'");
                    }
                    if (!String.IsNullOrEmpty(updateFlag))
                    {
                        sb.AppendLine($",UPDATE_FLAG = '{updateFlag}'");
                    }
                    if (!String.IsNullOrEmpty(frontNo))
                    {
                        sb.AppendLine($",FRONT_NO = '{frontNo}'");
                    }
                    if (!String.IsNullOrEmpty(backNo))
                    {
                        sb.AppendLine($",BACK_NO = '{backNo}'");
                    }
                    if (!String.IsNullOrEmpty(updateBy))
                    {
                        sb.AppendLine($",UPDATE_BY = '{updateBy}'");
                    }
                    if (!String.IsNullOrEmpty(lastUpdate))
                    {
                        sb.AppendLine($",LAST_UPDATE = to_date('{lastUpdate}','dd/MM/yyyy HH24:MI:SS')");
                    }
                    if (!String.IsNullOrEmpty(lastRemark))
                    {
                        sb.AppendLine($",LAST_REMARK = '{lastRemark}'");
                    }
                    if (!String.IsNullOrEmpty(handicap))
                    {
                        sb.AppendLine($",HANDICAP = '{handicap}'");
                    }
                    if (!String.IsNullOrEmpty(cardType))
                    {
                        sb.AppendLine($",CARD_TYPE = '{cardType}'");
                    }
                    if (!String.IsNullOrEmpty(cardSts))
                    {
                        sb.AppendLine($",CARD_STS = '{cardSts}'");
                    }
                    if (!String.IsNullOrEmpty(cardID))
                    {
                        sb.AppendLine($"Where CARD_ID = '{cardID}'");
                    }

                    string sql = sb.ToString();

                    conn.Execute(sql);

                    string queryDB = string.Empty;

                    if (!String.IsNullOrEmpty(cardIdEdit))
                    {
                        queryDB = $"select * from Engineer.ACL_CARD Where CARD_ID = '{cardIdEdit}'";
                    }
                    else
                    {
                        queryDB = $"select * from Engineer.ACL_CARD Where CARD_ID = '{cardID}'";
                    }

                    return conn.Query<Acl_CardModel>(queryDB).ToList();
                }
            }
            catch (Exception)
            {

                throw;
            }



        }
    }
}