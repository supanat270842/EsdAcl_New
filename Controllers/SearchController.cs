using EsdAcl_New.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Newtonsoft.Json;

namespace EsdAcl_New.Controllers
{
    public class SearchController : BaseController
    {
        public async Task<IActionResult> Index()
        {
            var list = await Services.NetworkService.GetRemark();
            ViewData["Remark"] = new SelectList(list.list, "esd_remark_id", "esd_remark_desc");

            return View();
        }

        public async Task<JsonResult> GetSearch(InputSearch param)
        {
            try
            {
                string _sDate = string.Empty;
                string _eDate = string.Empty;
                if (!string.IsNullOrEmpty(param.txtDateSt) && !string.IsNullOrEmpty(param.txtDateEn))
                {
                    DateTime stDateParse = DateTime.Parse(param.txtDateSt);
                    DateTime edDateParse = DateTime.Parse(param.txtDateEn);

                    _sDate = stDateParse.ToString("dd/MM/yyyy HH:mm:ss");
                    _eDate = edDateParse.ToString("dd/MM/yyyy HH:mm:ss");
                }
                else
                {
                    _sDate = string.Empty;
                    _eDate = string.Empty;
                }

                List<ListSearch> listSearches = new List<ListSearch>();
                var list = await Services.NetworkService.GetSearch(param, _sDate, _eDate);

                foreach (var item in list.list)
                {

                    var lisrRemark = await Services.NetworkService.GetRemarkName(item.lasT_REMARK);

                    listSearches.Add(new ListSearch()
                    {
                        carD_ID = item.carD_ID,
                        emP_NO = item.emP_NO,
                        emP_NAME = item.emP_NAME,
                        depT_CODE = item.depT_CODE,
                        depT_NAME = item.depT_NAME,
                        position = item.position,
                        updatE_FLAG = item.updatE_FLAG,
                        fronT_NO = item.fronT_NO,
                        bacK_NO = item.bacK_NO,
                        updatE_BY = item.updatE_BY,
                        lasT_UPDATE = item.lasT_UPDATE,
                        lasT_REMARK = lisrRemark.list[0].esd_remark_desc,
                        handicap = item.handicap,
                        carD_TYPE = item.carD_TYPE,
                        carD_STS = item.carD_STS,
                    });
                }

                return Json(new { Result = true, Message = "Success", List = JsonConvert.SerializeObject(listSearches) });
            }
            catch (Exception ex)
            {
                return Json(new { Result = false, Message = ex.Message });
            }
        }
    }
}
