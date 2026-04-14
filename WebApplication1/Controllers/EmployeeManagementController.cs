using Microsoft.AspNetCore.Mvc;
namespace WebApplication1.Controllers
{
    [Route("api/controller")]
    [ApiController]
    public class EmployeeManagementController : ControllerBase
    {
        [HttpGet]
        public IActionResult GetEmployee()
        {
            return Ok();
        }
    }
}
