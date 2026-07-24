using BCVP.Net8.IService;
using BCVP.Net8.Repository.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BCVP.Net8.Service
{
    public class BaseService<TEntity, TV0> : IBaseService<TEntity, TV0> where TEntity : class, new()
    {
        public Task<TEntity> CreateAsync(TEntity entity)
        {
            throw new NotImplementedException();
        }

        public async Task<List<TEntity>> Query()
        {
            var baseRepo = new BaseRepository<TEntity>();
            var list = await baseRepo.Query();
            return list;
        }
    }
}
