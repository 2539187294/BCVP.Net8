using AutoMapper;
using BCVP.Net8.Model;

namespace BCVP.Net8.Common
{
    public class CustomProflie : Profile
    {
        public CustomProflie() 
        {
            CreateMap<Role, RoleVO>().ForMember(a => a.RoleName, o => o.MapFrom(d => d.Name));
            CreateMap<RoleVO, Role>().ForMember(a => a.Name, o => o.MapFrom(d => d.RoleName));
        }
    }
}
