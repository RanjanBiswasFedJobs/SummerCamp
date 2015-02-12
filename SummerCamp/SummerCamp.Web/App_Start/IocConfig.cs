using System.Web.Http;
using SummerCamp.Data;
using SummerCamp.Data.Contracts;
using Ninject;
using SummerCamp.Data;
using SummerCamp.Web.Helper;

namespace SummerCamp.Web
{
    public class IocConfig
    {
        public static void RegisterIoc(HttpConfiguration config)
        {
            var kernel = new StandardKernel(); // Ninject IoC

           

            kernel.Bind<RepositoryFactories>().To<RepositoryFactories>()
                .InSingletonScope();

            kernel.Bind<IRepositoryProvider>().To<RepositoryProvider>();
            kernel.Bind<ISummerCampUow>().To<SummerCampUow>();
            kernel.Bind<IServerDataRestClient>().To<ServerDataRestClient>();

            // Tell WebApi how to use our Ninject IoC
            config.DependencyResolver = new NinjectDependencyResolver(kernel);
        }
    }
}