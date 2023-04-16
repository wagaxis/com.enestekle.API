using AutoMapper;

namespace Business.Config
{
    public class MapperConfig
    {
        public static IMapper Configure()
        {

            var config = new MapperConfiguration(cfg =>
            {
            });
            return config.CreateMapper();
        }
    }
}
