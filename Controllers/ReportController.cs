using Microsoft.AspNetCore.Mvc;

namespace EsdAcl_New.Controllers
{
    public class ReportController : BaseController
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult TimeAttReport()
        {
            return View();
        }

        public IActionResult TimeAttSummary()
        {
            return View();
        }
    }
}
