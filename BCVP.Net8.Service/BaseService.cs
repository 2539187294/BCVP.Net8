using AutoMapper;
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
        private readonly IMapper _mapper;
        private readonly IBaseRepository<TEntity> _baseRepository;
        //public ISqlSugarClient Db => _baseRepository.Db;

        public BaseService(IMapper mapper, IBaseRepository<TEntity> baseRepository)
        {
            _mapper = mapper;
            _baseRepository = baseRepository;
        }

        public Task<TEntity> CreateAsync(TEntity entity)
        {
            throw new NotImplementedException();
        }

        public async Task<List<TV0>> Query()
        {
            var baseRepo = new BaseRepository<TEntity>();
            var list = await _baseRepository.Query();
            var llout = _mapper.Map<List<TV0>>(list);
            return llout;
        }
    }
}
