using EsdAcl_API.Models;
using Microsoft.AspNetCore.Mvc;

namespace EsdAcl_API.Controllers
{
    [ApiController]
    [Route("api/[Controller]")]
    public class GetController : Controller
    {
        [HttpGet]
        [Route("GetUserNo")]
        public async Task<IActionResult> GetUserNo(string empNo)
        {
            try
            {
                Employee_Resposity repo = new Employee_Resposity();
                List<EmployeeModel> employees = repo.GetUserNoDB(empNo);

                return Ok(new { Results = true, Message = "Success", List = employees });
            }
            catch (Exception ex)
            {
                return NotFound(new { Result = false, Message = ex.Message });
            }
        }

        [HttpGet]
        [Route("GetRemark")]
        public async Task<IActionResult> GetRemark()
        {
            try
            {
                GetRemark_Resposity repo = new GetRemark_Resposity();
                List<GetRemarkModels> remark = repo.GetRemark();

                return Ok(new { Results = true, Message = "Success", List = remark });
            }
            catch (Exception ex)
            {
                return NotFound(new { Result = false, Message = ex.Message });
            }
        }

        [HttpGet]
        [Route("GetRemarkName")]
        public async Task<IActionResult> GetRemarkName(string remarkId)
        {
            try
            {
                GetRemark_Resposity repo = new GetRemark_Resposity();
                List<remark_nameModel> remark = repo.GetRemarkName(remarkId);

                return Ok(new { Results = true, Message = "Success", List = remark });
            }
            catch (Exception ex)
            {
                return NotFound(new { Result = false, Message = ex.Message });
            }
        }

        [HttpGet]
        [Route("GetACL")]
        public async Task<IActionResult> GetACL()
        {
            try
            {
                ACL_Resposity repo = new ACL_Resposity();
                List<ACL_Model> acl = repo.GetACL();

                return Ok(new { Results = true, Message = "Success", List = acl });
            }
            catch (Exception ex)
            {
                return NotFound(new { Result = false, Message = ex.Message });
            }
        }

        [HttpGet]
        [Route("GetSearch")]
        public async Task<IActionResult> GetSearch([FromQuery]INPUT_SearchModel data)
        {
            try
            {
                Search_Repository repo = new Search_Repository();
                List<SearchModel> acl = repo.GetSearch(data);

                //GetRemark_Resposity repoRemark = new GetRemark_Resposity();
                //List<GetRemarkModels> remark = repoRemark.GetRemark();

                return Ok(new { Results = true, Message = "Success", List = acl });
            }
            catch (Exception ex)
            {
                return NotFound(new { Result = false, Message = ex.Message });
            }
        }

    }
}
