using IYTEthesis.Data;
using IYTEthesis.Data.Contracts;

using System.Web.Http;
using Ninject;

namespace IYTEthesis
{
    public class IocConfig
    {
        public static void RegisterIoc(HttpConfiguration config)
        {
            var kernel = new StandardKernel(); // Ninject IoC

            // These registrations are "per instance request".
            // See http://blog.bobcravens.com/2010/03/ninject-life-cycle-management-or-scoping/

            kernel.Bind<RepositoryFactories>().To<RepositoryFactories>()
                .InSingletonScope();

            kernel.Bind<IRepositoryProvider>().To<RepositoryProvider>();
            kernel.Bind<IiyteThesisUow>().To<IYTEthesisUow>();

            // Tell WebApi how to use our Ninject IoC
            //NinjectDependencyResolver taken from dotNet team
            config.DependencyResolver = new NinjectDependencyResolver(kernel);

        }
    }
}