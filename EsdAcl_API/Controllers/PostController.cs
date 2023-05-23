using EsdAcl_API.Models;
using EsdAcl_API.Models.engineer;
using Microsoft.AspNetCore.Mvc;

namespace EsdAcl_API.Controllers
{
    [ApiController]
    [Route("api/[Controller]")]
    public class PostController : Controller
    {
        private ModelContext _db;
        public PostController(ModelContext db)
        {
            _db = db;
        }

        [HttpPost]
        [Route("CreateACL")]
        public async Task<IActionResult> CreateACL([FromQuery] CreateAclModel data)
        {
            try
            {
                CreateAclModel_Resposity repo = new CreateAclModel_Resposity();
                List<CreateAclModelPost> createAcls =  repo.CreateACL(data);

                return Ok(new { Results = true, Message = "Success", List = createAcls });
            }
            catch (Exception ex)
            {
                return NotFound(new { Result = false, Message = ex.Message });
            }
        }
    }
}
