using EsdAcl_New.Models;
using System.DirectoryServices;

namespace EsdAcl_New.Services.Helpers
{
    public class ActiveDirectoryService
    {
        public ResultCheckADModel CheckLoginActiveDirectory(string USER, string PASS, string DOMAIN)
        {
            ResultCheckADModel result = new ResultCheckADModel();

            string domain = DOMAIN + ".ad.celestica.com";

            try
            {
                DirectoryEntry adsRoot = new DirectoryEntry();
                adsRoot.AuthenticationType = AuthenticationTypes.Secure;
                adsRoot.Path = "LDAP://" + domain;
                adsRoot.Username = domain + @"\" + USER;

                adsRoot.Password = PASS;
                DirectorySearcher adsSearch = new DirectorySearcher(adsRoot);
                DirectoryEntry userDE;
                adsSearch.PropertiesToLoad.Add("sAMAccountName");
                adsSearch.PropertiesToLoad.Add("memberof");
                adsSearch.PropertiesToLoad.Add("cn");
                adsSearch.PropertiesToLoad.Add("FullName");
                adsSearch.PropertiesToLoad.Add("email");

                adsSearch.Filter = "(&(sAMAccountName=" + USER + ")(!userAccountControl:1.2.840.113556.1.4.803:=2))";
                SearchResult oResult;
                oResult = adsSearch.FindOne();

                if (oResult != null)
                {
                    userDE = oResult.GetDirectoryEntry();
                    //userInfo = userDE.Name + ":Access" + ":Access";
                    if (userDE == null) { throw new Exception("Username, Password is incorrect! #1"); }
                    if (!string.IsNullOrEmpty(userDE.Name) && userDE.Name.IndexOf(":") >= 0)
                    {
                        string[] ArrStr = userDE.Name.Split(':');
                        string[] ArrStr2 = userDE.Username.Split('\\');

                        if (ArrStr.Length >= 2 && ArrStr2.Length >= 2)
                        {
                            string FULL_NAME = ArrStr[0].ToString().Substring(3);
                            string USER_NAME = ArrStr2[1].ToString();
                            string user_type = "USER";

                            result.FULL_NAME = FULL_NAME;
                            result.USER_NAME = USER_NAME;
                            result.USER_TYPE = user_type;
                            result.Success = true;
                            result.Message = "";
                        }
                        else
                        {
                            throw new Exception("Username, Password is incorrect! #2");
                        }
                    }
                }
            }

            catch (Exception ex)
            {
                result.FULL_NAME = string.Empty;
                result.USER_NAME = string.Empty;
                result.Success = false;
                result.Message = ex.Message;
            }

            return result;
        }
    }
}
