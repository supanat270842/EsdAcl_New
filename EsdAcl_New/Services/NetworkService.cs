using EsdAcl_New.Models;
using Newtonsoft.Json;
using System.Net.Http;
using System.Security.Policy;
using System.Text;

namespace EsdAcl_New.Services
{
    public class NetworkService
    {
        public static async Task<EmployeeModel> GetEmployee(INPUT_Employee param)
        {
            using (HttpClient client = new HttpClient())
            {
                int keyEmp = Convert.ToInt32(param.txtEmp);
                string empNo = keyEmp.ToString("00000000");
                try
                {
                    const string baseUrl = "https://localhost:7162";
                    string function = "/api/Get/GetUserNo" +
                    $"?empNo={empNo}";

                    client.BaseAddress = new Uri(baseUrl);
                    var response = await client.GetAsync(function);
                    response.EnsureSuccessStatusCode();

                    var strResponse = await response.Content.ReadAsStringAsync();
                    EmployeeModel result = JsonConvert.DeserializeObject<EmployeeModel>(strResponse);

                    return result;
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }
        }

        public static async Task<RemarkModel> GetRemark()
        {
            using (HttpClient client = new HttpClient())
            {
                try
                {
                    const string baseUrl = "https://localhost:7162";
                    string function = "/api/Get/GetRemark";

                    client.BaseAddress = new Uri(baseUrl);
                    var response = await client.GetAsync(function);
                    response.EnsureSuccessStatusCode();

                    var strResponse = await response.Content.ReadAsStringAsync();
                    RemarkModel result = JsonConvert.DeserializeObject<RemarkModel>(strResponse);

                    return result;
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }
        }

        public static async Task<RemarkNameModel> GetRemarkName(string remarkId)
        {
            using (HttpClient client = new HttpClient())
            {
                try
                {
                    const string baseUrl = "https://localhost:7162";
                    string function = "/api/Get/GetRemarkName" + 
                        $"?remarkId={remarkId}";

                    client.BaseAddress = new Uri(baseUrl);
                    var response = await client.GetAsync(function);
                    response.EnsureSuccessStatusCode();

                    var strResponse = await response.Content.ReadAsStringAsync();
                    RemarkNameModel result = JsonConvert.DeserializeObject<RemarkNameModel>(strResponse);

                    return result;
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }
        }

        public static async Task<AClModel> GetACL()
        {
            using (HttpClient client = new HttpClient())
            {
                try
                {
                    const string baseUrl = "https://localhost:7162";
                    string function = "/api/Get/GetACL";

                    client.BaseAddress = new Uri(baseUrl);
                    var response = await client.GetAsync(function);
                    response.EnsureSuccessStatusCode();

                    var strResponse = await response.Content.ReadAsStringAsync();
                    AClModel result = JsonConvert.DeserializeObject<AClModel>(strResponse);

                    return result;
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }
        }

        public static async Task<SearchModel> GetSearch(InputSearch param, string _sDate, string _eDate)
        {
            using (HttpClient client = new HttpClient())
            {
                try
                {
                    string empNo = param.txtEmpNo;
                    string empName = param.txtEmpName;
                    string frontNo = param.txtFront;
                    string backNo = param.txtBack;
                    string cardNo = param.txtCard;
                    string cardType = param.txtCType;
                    string stDate = _sDate;
                    string enDate = _eDate;
                    string createBy = param.txtCreateBy;
                    string cardSts = param.txtCardStatus;
                    string remark = param.txtRemark;

                    const string baseUrl = "https://localhost:7162";
                    string function = "/api/Get/GetSearch" +
                    $"?empNo={empNo}";

                    StringBuilder sb = new StringBuilder();

                    if (!string.IsNullOrEmpty(empName))
                    {
                        sb.Append("&empName=" + empName);
                    }
                    if (!string.IsNullOrEmpty(frontNo))
                    {
                        sb.Append("&frontNo=" + frontNo);
                    }
                    if (!string.IsNullOrEmpty(backNo))
                    {
                        sb.Append("&backNo=" + backNo);
                    }
                    if (!string.IsNullOrEmpty(cardNo))
                    {
                        sb.Append("&cardNo=" + cardNo);
                    }
                    if (!string.IsNullOrEmpty(cardType))
                    {
                        sb.Append("&cardType=" + cardType);
                    }
                    if (!string.IsNullOrEmpty(createBy))
                    {
                        sb.Append("&createBy=" + createBy);
                    }
                    if (!string.IsNullOrEmpty(stDate))
                    {
                        sb.Append("&stDate=" + stDate);
                    }
                    if (!string.IsNullOrEmpty(enDate))
                    {
                        sb.Append("&enDate=" + enDate);
                    }
                    if (!string.IsNullOrEmpty(cardSts))
                    {
                        sb.Append("&cardSts=" + cardSts);
                    }
                    if (!string.IsNullOrEmpty(remark))
                    {
                        sb.Append("&remark=" + remark);
                    }

                    string merge_function = function + sb.ToString();

                    client.BaseAddress = new Uri(baseUrl);
                    var response = await client.GetAsync(merge_function);
                    response.EnsureSuccessStatusCode();

                    var strResponse = await response.Content.ReadAsStringAsync();
                    SearchModel result = JsonConvert.DeserializeObject<SearchModel>(strResponse);

                    return result;
                }
                catch (HttpRequestException e)
                {
                    throw new InvalidOperationException("GetSearch" + e.Message);
                }
            }
        }

        public static async Task<CreateAclModel1> CreateACL(CreateAclModel insertDb)
        {
            using (HttpClient client = new HttpClient())
            {
                try
                {
                    string cardId = insertDb.cardId;
                    string empNo = insertDb.empNo;
                    string empName = insertDb.empName;
                    string deptCode = insertDb.deptCode;
                    string deptName = insertDb.deptName;
                    string position = insertDb.position;
                    string updateFlag = insertDb.updateFlag;
                    string frontNo = insertDb.frontNo;
                    string backNo = insertDb.backNo;
                    string updateBy = insertDb.updateBy;
                    string lastRemark = insertDb.lastRemark;
                    string handicap = insertDb.handicap;
                    string cardSts = insertDb.cardSts;
                    string cardType = insertDb.cardType;


                    const string baseUrl = "https://localhost:7162";
                    string function = "/api/Post/CreateACL" +
                    $"?CARD_ID={cardId}&EMP_NO={empNo}";

                    StringBuilder sb = new StringBuilder();

                    if (!string.IsNullOrEmpty(empName))
                    {
                        sb.Append("&EMP_NAME=" + empName);
                    }
                    if (!string.IsNullOrEmpty(deptCode))
                    {
                        sb.Append("&DEPT_CODE=" + deptCode);
                    }
                    if (!string.IsNullOrEmpty(deptName))
                    {
                        sb.Append("&DEPT_NAME=" + deptName);
                    }
                    if (!string.IsNullOrEmpty(position))
                    {
                        sb.Append("&POSITION=" + position);
                    }
                    if (!string.IsNullOrEmpty(updateFlag))
                    {
                        sb.Append("&UPDATE_FLAG=" + updateFlag);
                    }
                    if (!string.IsNullOrEmpty(frontNo))
                    {
                        sb.Append("&FRONT_NO=" + frontNo);
                    }
                    if (!string.IsNullOrEmpty(backNo))
                    {
                        sb.Append("&BACK_NO=" + backNo);
                    }
                    if (!string.IsNullOrEmpty(updateBy))
                    {
                        sb.Append("&UPDATE_BY=" + updateBy);
                    }
                    if (!string.IsNullOrEmpty(lastRemark))
                    {
                        sb.Append("&LAST_REMARK=" + lastRemark);
                    }
                    if (!string.IsNullOrEmpty(handicap))
                    {
                        sb.Append("&HANDICAP=" + handicap);
                    }
                    if (!string.IsNullOrEmpty(cardType))
                    {
                        sb.Append("&CARD_TYPE=" + cardType);
                    }
                    if (!string.IsNullOrEmpty(cardSts))
                    {
                        sb.Append("&CARD_STS=" + cardSts);
                    }

                    string merge_function = function + sb.ToString();

                    client.BaseAddress = new Uri(baseUrl);
                    var httpContent = new StringContent("");
                    var response = await client.PostAsync(merge_function, httpContent);
                    response.EnsureSuccessStatusCode();


                    var strResponse = await response.Content.ReadAsStringAsync();
                    CreateAclModel1 result = JsonConvert.DeserializeObject<CreateAclModel1>(strResponse);

                    return result;
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }
        }

        public static async Task<EditAPIModel> EditACL(EditModel editModel)
        {
            using (HttpClient client = new HttpClient())
            {
                string cardID = editModel.txtHcardNo;
                string empNo = editModel.txtEmp;
                string empName = editModel.txtName;
                string position = editModel.txtPosition;
                string cardType = editModel.txtCType;
                string frontNo = editModel.txtFront;
                string backNo = editModel.txtBack;
                string updateBy = editModel.txtHupDateBy;
                string lastUpdate = DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss");
                string handicap = editModel.txtHand;
                string cardSts = editModel.txtCardsts;
                string lastRemark = editModel.txtRemark;

                try
                {
                    const string baseUrl = "https://localhost:7162";
                    string function = "/api/Put/EditEsdAcl";

                    StringBuilder sb = new StringBuilder();

                    if (!string.IsNullOrEmpty(cardID))
                    {
                        sb.Append("?CARD_ID=" + cardID);
                    }
                    if (!string.IsNullOrEmpty(empNo))
                    {
                        sb.Append("&EMP_NO=" + empNo);
                    }
                    if (!string.IsNullOrEmpty(empName))
                    {
                        sb.Append("&EMP_NAME=" + empName);
                    }
                    if (!string.IsNullOrEmpty(position))
                    {
                        sb.Append("&POSITION=" + position);
                    }
                    if (!string.IsNullOrEmpty(cardType))
                    {
                        sb.Append("&CARD_TYPE=" + cardType);
                    }
                    if (!string.IsNullOrEmpty(frontNo))
                    {
                        sb.Append("&FRONT_NO=" + frontNo);
                    }
                    if (!string.IsNullOrEmpty(backNo))
                    {
                        sb.Append("&BACK_NO=" + backNo);
                    }
                    if (!string.IsNullOrEmpty(updateBy))
                    {
                        sb.Append("&UPDATE_BY=" + updateBy);
                    }
                    if (!string.IsNullOrEmpty(handicap))
                    {
                        sb.Append("&HANDICAP=" + handicap);
                    }
                    if (!string.IsNullOrEmpty(cardSts))
                    {
                        sb.Append("&CARD_STS=" + cardSts);
                    }
                    if (!string.IsNullOrEmpty(lastRemark))
                    {
                        sb.Append("&LAST_REMARK=" + lastRemark);
                    }

                    string merge_function = function + sb.ToString();


                    client.BaseAddress = new Uri(baseUrl);
                    var httpContent = new StringContent("");
                    var response = await client.PutAsync(merge_function, httpContent);
                    response.EnsureSuccessStatusCode();

                    var strResponse = await response.Content.ReadAsStringAsync();
                    EditAPIModel result = JsonConvert.DeserializeObject<EditAPIModel>(strResponse);

                    return result;
                }
                catch (HttpRequestException e)
                {
                    throw new InvalidOperationException("EditACL" + e.Message);
                }
            }
        }

        public static async Task<ListDelete> DeleteACL(string txtCard)
        {
            using (HttpClient client = new HttpClient())
            {
                try
                {
                    const string baseUrl = "https://localhost:7162";
                    string function = "/api/Delete/DeleteACL" +
                    $"?CARD_ID={txtCard}";

                    client.BaseAddress = new Uri(baseUrl);
                    var httpContent = new StringContent("");
                    var response = await client.DeleteAsync(function);
                    response.EnsureSuccessStatusCode();

                    var strResponse = await response.Content.ReadAsStringAsync();
                    ListDelete result = JsonConvert.DeserializeObject<ListDelete>(strResponse);

                    return result;
                }
                catch (HttpRequestException e)
                {
                    throw new InvalidOperationException("DeleteACL" + e.Message);
                }
            }
        }
    }
}
