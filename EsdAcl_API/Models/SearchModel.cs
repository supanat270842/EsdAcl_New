using Dapper;
using Oracle.ManagedDataAccess.Client;
using System.Collections.Generic;
using System.Text;

namespace EsdAcl_API.Models
{
    public class SearchModel
    {
        public string CARD_ID { get; set; }
        public string EMP_NO { get; set; }
        public string EMP_NAME { get; set; }
        public string DEPT_CODE { get; set; }
        public string DEPT_NAME { get; set; }
        public string POSITION { get; set; }
        public string UPDATE_FLAG { get; set; }
        public string FRONT_NO { get; set; }
        public string BACK_NO { get; set; }
        public string UPDATE_BY { get; set; }
        public string LAST_UPDATE { get; set; }
        public string LAST_REMARK { get; set; }
        public string HANDICAP { get; set; }
        public string CARD_TYPE { get; set; }
        public string CARD_STS { get; set; }

    }
    public class INPUT_SearchModel
    {
        public string? empNo { get; set; }
        public string? empName { get; set; }
        public string? frontNo { get; set; }
        public string? backNo { get; set; }
        public string? cardNo { get; set; }
        public string? cardType { get; set; }
        public string? createBy { get; set; }
        public string? stDate { get; set; }
        public string? enDate { get; set; }
        public string? cardSts { get; set; }
        public string? remark { get; set; }
    }

    public class Search_Repository
    {
        public List<SearchModel> GetSearch(INPUT_SearchModel data)
        {
            string empNo = data.empNo;
            string empName = data.empName;
            string frontNo = data.frontNo;
            string backNo = data.backNo;
            string cardNo = data.cardNo;
            string cardType = data.cardType;
            string createBy = data.createBy;
            string stDate = data.stDate;
            string enDate = data.enDate;
            string cardSts = data.cardSts;
            string remark = data.remark;

            try
            {
                List<SearchModel> result = new List<SearchModel>();

                string str = "Data Source=(DESCRIPTION=(ADDRESS_LIST=(ADDRESS=(PROTOCOL=TCP)(HOST= cthorap21.th-lcb.celestica.com)(PORT=1521)))(CONNECT_DATA=(SERVER=DEDICATED)(SERVICE_NAME=appstest))); User ID=robin;Password=pcjaws5t;";

                using (OracleConnection conn = new OracleConnection(str))
                {
                    string sql = @"
                                    Select * From (
                                    Select CARD_ID,EMP_NO,EMP_NAME,DEPT_CODE,DEPT_NAME,POSITION,UPDATE_FLAG 
                                    ,FRONT_NO,BACK_NO,UPDATE_BY,LAST_UPDATE ,LAST_REMARK,HANDICAP,CARD_TYPE,CARD_STS 
                                    From Engineer.ACL_CARD 
                                    Union 
                                    Select CARD_ID,EMP_NO,EMP_NAME,DEPT_CODE,DEPT_NAME,POSITION,UPDATE_FLAG 
                                    ,FRONT_NO,BACK_NO,UPDATE_BY,LAST_UPDATE ,LAST_REMARK,HANDICAP,CARD_TYPE,CARD_STS 
                                    From Engineer.ACL_CARD_NEW 
                                    ) 
                                    Where CARD_ID Is Not Null 
                                    ";
                    StringBuilder sb = new StringBuilder();

                    // ######################## CONDITION SEARCH ######################## //

                    if (!String.IsNullOrEmpty(empNo))
                    {
                        sb.Append($"And EMP_NO = '{empNo}'");
                    }
                    if (!String.IsNullOrEmpty(empName))
                    {
                        sb.Append($"And EMP_NAME = '{empName}'");
                    }
                    if (!String.IsNullOrEmpty(frontNo))
                    {
                        sb.Append($"And FRONT_NO = '{frontNo}'");
                    }
                    if (!String.IsNullOrEmpty(backNo))
                    {
                        sb.Append($"And BACK_NO = '{backNo}'");
                    }
                    if (!String.IsNullOrEmpty(cardNo))
                    {
                        sb.Append($"And CARD_ID = '{cardNo}'");
                    }
                    if (!String.IsNullOrEmpty(cardType))
                    {
                        sb.Append($"And CARD_TYPE = '{cardType}'");
                    }
                    if (!String.IsNullOrEmpty(createBy))
                    {
                        sb.Append($"And UPDATE_BY = '{createBy}'");
                    }

                    if (!string.IsNullOrEmpty(stDate) && !string.IsNullOrEmpty(enDate))
                    {
                        sb.AppendLine("AND LAST_UPDATE BETWEEN TO_DATE('" + stDate + "', 'dd/MM/yyyy HH24:MI:SS') AND TO_DATE('" + enDate + "', 'dd/MM/yyyy HH24:MI:SS')");
                    }
                    else if (!string.IsNullOrEmpty(stDate) && string.IsNullOrEmpty(enDate))
                    {
                        sb.AppendLine("AND LAST_UPDATE = TO_DATE('" + stDate + "', 'dd/MM/yyyy HH24:MI:SS')");
                    }
                    else if (string.IsNullOrEmpty(stDate) && !string.IsNullOrEmpty(enDate))
                    {
                        sb.AppendLine("AND LAST_UPDATE = TO_DATE('" + enDate + "', 'dd/MM/yyyy HH24:MI:SS')");
                    }
                    if (!String.IsNullOrEmpty(cardSts))
                    {
                        sb.Append($"And CARD_STS = '{cardSts}'");
                    }
                    if (!String.IsNullOrEmpty(remark))
                    {
                        sb.Append($"And LAST_REMARK = '{remark}'");
                    }

                    string merge_sql = sql + sb.ToString();

                    return conn.Query<SearchModel>(merge_sql).ToList();

                }
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
