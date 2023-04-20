using AutoMapper;

namespace com.enestekle.Business.Config
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
