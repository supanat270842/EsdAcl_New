using EsdAcl_New.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Newtonsoft.Json;

namespace EsdAcl_New.Controllers
{
    public class SearchController : BaseController
    {
        public async Task<IActionResult>  Index()
        {
            var list = await Services.NetworkService.GetRemark();
            ViewData["Remark"] = new SelectList(list.list, "esd_remark_id", "esd_remark_desc");

            return View();
        }

        public async Task<JsonResult> GetSearch(InputSearch param)
        
        {
            try
            {
                var list = await Services.NetworkService.GetSearch(param);

                return Json(new { Result = true, Message = "Success", List = JsonConvert.SerializeObject(list.list)});
            }
            catch (Exception ex)
            {
                return Json(new { Result = false, Message = ex.Message });
            }
        }
    }
}
