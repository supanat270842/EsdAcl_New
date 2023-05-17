using EsdAcl_New.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Newtonsoft.Json;

namespace EsdAcl_New.Controllers
{
    public class EditController : BaseController
    {
        public async Task<IActionResult> Index(string txtCard)
        {
            var list = await Services.NetworkService.GetRemark();
            ViewData["Remark"] = new SelectList(list.list, "esd_remark_id", "esd_remark_desc");

            InputSearch param = new InputSearch();
            param.txtCard = txtCard;
            var listCard = await Services.NetworkService.GetSearch(param);

            ListSearch listSearch = new ListSearch();
            listSearch.carD_ID = listCard.list[0].carD_ID;
            listSearch.updatE_BY = listCard.list[0].updatE_BY;
            listSearch.lasT_UPDATE = listCard.list[0].lasT_UPDATE;

            return View(listSearch);
        }

        public async Task<IActionResult> EditACL(EditModel editModel)
        {
            var data = await Services.NetworkService.EditACL(editModel);
            return RedirectToAction("Index", "Search");
        }

        public IActionResult Delete() 
        {
            return View();
        }
    }
}
