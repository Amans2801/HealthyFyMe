using HealthyFyMe.Core.DTO_s.Requests;
using Microsoft.AspNetCore.Mvc;

namespace HealthyFyMe.Controllers
{

    [ApiController]
    [Route("api/[controllers]")]
    public class UserControllers : ControllerBase
    {
        public UserControllers()
        {

        }

        [HttpPost("adduser")]
        public async Task<IActionResult> AddUser([FromBody] AdduserRequest addUserRequest)
        {

        }
    }
}
