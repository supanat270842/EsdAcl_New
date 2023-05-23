using AspNetCoreHero.ToastNotification.Abstractions;
using EsdAcl_New.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Newtonsoft.Json;

namespace EsdAcl_New.Controllers
{
    public class EditController : BaseController
    {
        private readonly INotyfService _notyfService;
        public EditController(INotyfService notyfService)
        {
            _notyfService = notyfService;
        }

        public async Task<IActionResult> Index(string txtCard)
        {
            var list = await Services.NetworkService.GetRemark();
            ViewData["Remark"] = new SelectList(list.list, "esd_remark_id", "esd_remark_desc");

            string _sDate = string.Empty;
            string _eDate = string.Empty;

            InputSearch param = new InputSearch();
            param.txtCard = txtCard;
            var listCard = await Services.NetworkService.GetSearch(param, _sDate, _eDate);

            ListSearch listSearch = new ListSearch();
            listSearch.carD_ID = listCard.list[0].carD_ID;
            listSearch.updatE_BY = listCard.list[0].updatE_BY;
            listSearch.lasT_UPDATE = listCard.list[0].lasT_UPDATE;

            return View(listSearch);
        }

        public async Task<IActionResult> EditACL(EditModel editModel)
        {
            try
            {
                int keyEmp = Convert.ToInt32(editModel.txtEmp);
                int keyFront = 0;
                int keyBack = 0;

                if (!String.IsNullOrEmpty(editModel.txtFront))
                {
                    keyFront = Convert.ToInt32(editModel.txtFront);
                }
                else
                {
                    string subFront = editModel.txtHcardNo.Substring(0,5);
                    keyFront = Convert.ToInt32(subFront);
                }

                if (!String.IsNullOrEmpty(editModel.txtBack))
                {
                    keyBack = Convert.ToInt32(editModel.txtBack);
                }
                else
                {
                    string subBack = editModel.txtHcardNo.Substring(5);
                    keyBack = Convert.ToInt32(subBack); 
                }

                string txtEmp = keyEmp.ToString("00000000");
                string txtFront = keyFront.ToString("00000");
                string txtBack = keyBack.ToString("00000");

                EditModel model = new EditModel();

                model.txtHcardNo = editModel.txtHcardNo;
                model.txtEmp = txtEmp;  
                model.txtName = editModel.txtName;
                model.txtPosition = editModel.txtPosition;
                model.txtCType = editModel.txtCType;
                model.txtFront = txtFront;
                model.txtBack = txtBack;
                model.txtHupDateBy = ViewBag.FullName;
                model.txtHand = editModel.txtHand;
                model.txtCardsts = editModel.txtCardsts;
                model.txtRemark = editModel.txtRemark;  
                model.txtHlastUpdate = editModel.txtHlastUpdate;

                var data = await Services.NetworkService.EditACL(model);
                return RedirectToAction(nameof(Index));
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }
        public async Task<IActionResult> DeleteACL(string txtCard)
        {
            var data = await Services.NetworkService.DeleteACL(txtCard);

            _notyfService.Success("Delete Success");
            return RedirectToAction("Index", "Search");
        }
    }
}
