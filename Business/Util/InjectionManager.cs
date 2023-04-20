using AutoMapper;
using Ninject.Modules;
using Ninject;
using com.enestekle.Business.Config;

namespace com.enestekle.Business.Util
{
    public class InjectionManager
    {
        private static IKernel Kernel { get; set; }

        public static T GetInstance<T>()
        {
            Kernel = new StandardKernel(new InstanceModule());
            return Kernel.Get<T>();
        }

    }

    public class InstanceModule : NinjectModule
    {
        public override void Load()
        {
            Bind<IMapper>().ToConstant(MapperConfig.Configure()).InSingletonScope();
        }
    }
}
