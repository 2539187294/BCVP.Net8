using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BCVP.Net8.IService
{
    public interface IBaseService<TEntity, TV0> where TEntity : class
    {
        Task<List<TV0>> Query(); 

        Task<TEntity> CreateAsync(TEntity entity);
    }
}
