using AutoMapper;
using BCVP.Net8.IService;
using BCVP.Net8.Model;
using BCVP.Net8.Repository.Base;
using BCVP.Net8.Service;
using Microsoft.AspNetCore.Mvc;

namespace BCVP.Net8.Controllers
{



    [ApiController]
    [Route("api/[controller]")]
    public class RoleController : ControllerBase
    {
        private readonly ILogger<RoleController> _logger;
        private readonly IMapper _mapper;
        private readonly IBaseService<Role,RoleVO> _baseService;

        public RoleController(ILogger<RoleController> logger, IMapper mapper, IBaseService<Role, RoleVO> baseService)
        {
            _logger = logger;
            _mapper = mapper;
            _baseService =  baseService;
        }

        [HttpGet]
        public async Task<List<RoleVO>> GetRole()
        {
            var roleList = await _baseService.Query();

            return roleList;
        }
    }
}
