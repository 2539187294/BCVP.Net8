using BCVP.Net8.Model;
using BCVP.Net8.Service;
using Microsoft.AspNetCore.Mvc;

namespace BCVP.Net8.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class UserController : ControllerBase
    {
        private readonly ILogger<UserController> _logger;

        public UserController(ILogger<UserController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public async Task<List<UserVO>> GetUser()
        {
            var userService = new UserService();
            var userList = await userService.GetUser();
            return userList;
        }

    }
}
