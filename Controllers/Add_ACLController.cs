using AspNetCoreHero.ToastNotification.Abstractions;
using EsdAcl_New.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Newtonsoft.Json;
using System.Linq;

namespace EsdAcl_New.Controllers
{
    public class Add_ACLController : BaseController
    {
        private readonly INotyfService _notyfService;

        public Add_ACLController(INotyfService notyfService)
        {
            _notyfService = notyfService;
        }

        public async Task<IActionResult> Index()
        {
            var list = await Services.NetworkService.GetRemark();
            ViewData["Remark"] = new SelectList(list.list, "esd_remark_id", "esd_remark_desc");

            return View();
        }

        public async Task<JsonResult> GetRemark()
        {
            try
            {
                var list = await Services.NetworkService.GetRemark();
                return Json(new { Result = true, Message = "Success", List = JsonConvert.SerializeObject(list.list) });
            }
            catch (Exception ex)
            {
                return Json(new { Result = false, Message = ex.Message });
            }
        }

        public async Task<JsonResult> GetUserNo(INPUT_Employee param)
        {
            try
            {
                var list = await Services.NetworkService.GetEmployee(param);
                return Json(new { Result = true, Message = "Success", List = JsonConvert.SerializeObject(list.list) });
            }
            catch (Exception ex)
            {
                return Json(new { Result = false, Message = ex.Message });
            }
        }

        public async Task<JsonResult> GetACL()
        {
            try
            {
                List<ListAcl> listAcls = new List<ListAcl>();

                var list = await Services.NetworkService.GetACL();
               
                foreach (var item in list.list)
                {
                    var listNameRemark = await Services.NetworkService.GetRemarkName(item.lasT_REMARK);

                    listAcls.Add(new ListAcl()
                    {
                        carD_ID = item.carD_ID,
                        emP_NO = item.emP_NO,
                        emP_NAME = item.emP_NAME,
                        updatE_BY = item.updatE_BY,
                        lasT_UPDATE = item.lasT_UPDATE,
                        carD_TYPE = item.carD_TYPE,
                        lasT_REMARK = listNameRemark.list[0].esd_remark_desc
                    });
                }

                return Json(new { Result = true, Message = "Success", List = JsonConvert.SerializeObject(listAcls) });
            }
            catch (Exception ex)
            {
                return Json(new { Result = false, Message = ex.Message });
            }
        }

        public async Task<IActionResult> CreateACL(ADD_EmployeeModel param)
        {
            try
            {
                int keyEmp = Convert.ToInt32(param.txtEmp);
                int keyFront = Convert.ToInt32(param.txtFront);
                int keyBack = Convert.ToInt32(param.txtBack);

                string txtEmp = keyEmp.ToString("00000000");
                string txtFront = keyFront.ToString("00000");
                string txtBack = keyBack.ToString("00000");

                CreateAclModel insertDb = new CreateAclModel();

                insertDb.cardId = txtFront + txtBack;
                insertDb.empNo = txtEmp;
                insertDb.empName = param.txtName;
                insertDb.deptCode = string.Empty;
                insertDb.deptName = string.Empty;
                insertDb.position = param.txtPosition;
                insertDb.updateFlag = "NEW";
                insertDb.frontNo = txtFront;
                insertDb.backNo = txtBack;
                insertDb.updateBy = ViewBag.FullName;
                insertDb.lastRemark = param.txtRemark;
                insertDb.handicap = param.txtHand;
                insertDb.cardType = param.txtCType;
                insertDb.cardSts = "ACT";

                await Services.NetworkService.CreateACL(insertDb);
                return RedirectToAction(nameof(Index));
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }



    }
}
