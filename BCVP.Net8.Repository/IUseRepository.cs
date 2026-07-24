using BCVP.Net8.Model;

namespace BCVP.Net8.Repository
{
    public interface IUseRepository
    {
        Task<List<User>> GetUser(); 
    }
}
