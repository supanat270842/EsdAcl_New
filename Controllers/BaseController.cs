using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using System.Security.Claims;

namespace EsdAcl_New.Controllers
{
    public class BaseController : Controller
    {
        public override void OnActionExecuting(ActionExecutingContext context)
        {
            var identity = (ClaimsIdentity)User.Identity;

            ViewBag.ProjectName = "eRSN NEW";
            if (User.Identity.Name != null)
            {
                ViewBag.FullName = "ASIA" + @"\" +  User.Identity.Name.Substring(0, User.Identity.Name.Length - 11);
                ViewBag.Name = User.Identity.Name.Substring(0, User.Identity.Name.Length - 11);
                var ipAddress = User.Identity.Name;
                ViewBag.ID = ipAddress.Substring(User.Identity.Name.Length - 10);
                ViewBag.IP = Request.HttpContext.Connection.RemoteIpAddress;
            }
            else
            {
                ViewBag.FullName = "GUEST";
                ViewBag.ID = "UNKNOW";
                ViewBag.Name = "GUEST";
                ViewBag.IP = "ERROR";
                ViewData["EXID"] = "null";
            }

            base.OnActionExecuting(context);
        }

        public override void OnActionExecuted(ActionExecutedContext context)
        {
            base.OnActionExecuted(context);
        }
    }
}
