using EsdAcl_New.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace EsdAcl_New.Controllers
{
    //[Authorize]
    public class HomeController : BaseController
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Contract()
        {
            return View();
        }
    }
}