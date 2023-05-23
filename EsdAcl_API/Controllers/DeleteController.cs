using EsdAcl_API.Models;
using Microsoft.AspNetCore.Mvc;

namespace EsdAcl_API.Controllers
{
    [ApiController]
    [Route("api/[Controller]")]
    public class DeleteController : Controller
    {
        [HttpDelete]
        [Route("DeleteACL")]
        public async Task<IActionResult> DeleteACL([FromQuery] DeleteModel deleteModel)
        {
            try
            {
                Delete_resposity repo = new Delete_resposity();
                List<DeleteModel> deleteModels = repo.DeleteACL(deleteModel);

                return Ok(new { Results = true, Message = "Delete Success", List = deleteModel });
            }
            catch (Exception ex)
            {
                return NotFound(new { Result = false, Message = ex.Message });
            }
        }
    }
}
