using EsdAcl_New.Models;

namespace EsdAcl_New.Services.Helpers
{
    public class LoginHelper
    {
        public ResultCheckADModel CheckAuthorize(string USER, string PASS, string DOMAIN = "asia")
        {
            string result = string.Empty;
            ActiveDirectoryService AD = new ActiveDirectoryService();
            ResultCheckADModel resultCheckADModel = AD.CheckLoginActiveDirectory(USER, PASS, DOMAIN);

            if (resultCheckADModel.Success.Equals(false)) { throw new Exception(resultCheckADModel.Message); }

            return resultCheckADModel;
        }
    }
}
