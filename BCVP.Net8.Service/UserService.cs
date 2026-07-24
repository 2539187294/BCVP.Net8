using BCVP.Net8.Model;
using BCVP.Net8.Repository;

namespace BCVP.Net8.Service
{
    public class UserService : IUserService
    {
        public async Task<List<UserVO>> GetUser()
        {
            var userRepo = new UseRepository();
            var User = await userRepo.GetUser();

            return User.Select(x => new UserVO { UserName = x.Name }).ToList();
        }
    }
}
