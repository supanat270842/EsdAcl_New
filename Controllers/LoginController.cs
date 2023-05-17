using EsdAcl_New.Models;
using EsdAcl_New.Services.Helpers;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Mvc;
using NuGet.Protocol.Plugins;
using System.Security.Claims;

namespace EsdAcl_New.Controllers
{
    public class LoginController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public JsonResult GetDomainName()
        {
            try
            {
                bool result = false;
                string msg = string.Empty;
                List<DomainModel> listData = new List<DomainModel>();

                Domain_Repository repo = new Domain_Repository();
                listData = repo.GetDomainName();

                if (listData.Count > 0)
                {
                    result = true;
                    msg = "Success";
                }
                else
                {
                    result = false;
                    msg = "Error not found any data!";
                }

                return Json(new { result = result, message = msg, list = listData });

            }
            catch (Exception ex)
            {

                return Json(new { result = false, message = ex });
            }
        }

        public JsonResult CheckLogin(string USER, string PASS, string DOMAIN)
        {
            try
            {
                bool result = false;
                ClaimsIdentity claim = null;
                string Message = string.Empty;

                LoginHelper loginHelper = new LoginHelper();
                ResultCheckADModel resultCheckADModel = loginHelper.CheckAuthorize(USER.ToUpper(), PASS, DOMAIN);

                string full_name = resultCheckADModel.FULL_NAME;
                string user_name = resultCheckADModel.USER_NAME;

                if (!string.IsNullOrEmpty(user_name))
                {
                    TempData["FULL_NAME"] = full_name;
                    TempData["USER_NAME"] = user_name;
                    result = true;
                    Message = "Successfully.";

                    claim = new ClaimsIdentity(new[] {
                        new Claim(ClaimTypes.Name, full_name + " " + user_name),
                    }, CookieAuthenticationDefaults.AuthenticationScheme);
                }
                else
                {
                    TempData["FULL_NAME"] = null;
                    TempData["USER_NAME"] = null;
                    result = false;
                    Message = "You don't have permission to access.";
                }

                if (result)
                {
                    var principal = new ClaimsPrincipal(claim);
                    HttpContext.SignInAsync(CookieAuthenticationDefaults.AuthenticationScheme, principal);
                }

                return Json(new { Result = result, Message = Message });
            }
            catch (Exception ex)
            {

                return Json(new { result = false, message = ex.Message });
            }

        }

        public IActionResult Logout()
        {
            HttpContext.SignOutAsync(CookieAuthenticationDefaults.AuthenticationScheme);
            return RedirectToAction(nameof(Index));
        }
    }
}
