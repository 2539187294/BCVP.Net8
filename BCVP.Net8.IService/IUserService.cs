using BCVP.Net8.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BCVP.Net8.IService
{
    public interface IUserService
    {
        Task<List<UserVO>> GetUser();
    }
}
