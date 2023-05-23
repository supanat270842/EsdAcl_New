using EsdAcl_API.Models;
using Microsoft.AspNetCore.Mvc;

namespace EsdAcl_API.Controllers
{
    [ApiController]
    [Route("api/[Controller]")]
    public class PutController : Controller
    {
        [HttpPut]
        [Route("EditEsdAcl")]
        public async Task<IActionResult> EditEsdAcl([FromQuery] EditAclModel editAclModel)
        {
            try
            {
                EditAclModel_Resposity repo = new EditAclModel_Resposity();
                List<Acl_CardModel> editAcls = repo.EditEsdAcl(editAclModel);

                return Ok(new { Results = true, Message = "Success", List = editAcls });
            }
            catch (Exception ex)
            {
                return NotFound(new { Result = false, Message = ex.Message });
            }
        }
    }
}
