using AutoMapper;

namespace BCVP.Net8.Common
{
    public class AutoMapperConfig
    {
        //public ILoggerFactory _loggerFactory;

        //public AutoMapperConfig(ILoggerFactory loggerFactory)
        //{
        //    _loggerFactory = loggerFactory;
        //}

        public static MapperConfiguration RegisterMappings()
        {
            return new MapperConfiguration(cfg =>
            {
                cfg.AddProfile(new CustomProflie());
            });
        }
    }
}
