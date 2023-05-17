using EsdAcl_New.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Newtonsoft.Json;

namespace EsdAcl_New.Controllers
{
    public class Add_ACLController : BaseController
    {
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
                var list = await Services.NetworkService.GetACL();
                return Json(new { Result = true, Message = "Success", List = JsonConvert.SerializeObject(list.list) });
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
                insertDb.updateBy = ViewBag.Name;
                insertDb.lastRemark = param.txtRemark;
                insertDb.handicap = param.txtHand;
                insertDb.cardType = param.txtCType;
                insertDb.cardSts = "ACT";

                await Services.NetworkService.CreateACL(insertDb);

                return RedirectToAction("Index", "Add_ACL");
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }



    }
}
