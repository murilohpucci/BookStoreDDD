[assembly: WebActivator.PostApplicationStartMethod(typeof(ProjetoModeloDDD.Presentation.App_Start.SimpleInjectorInitializer), "Initialize")]

namespace ProjetoModeloDDD.Presentation.App_Start
{
    using System.Reflection;
    using System.Web.Mvc;
    using ProjetoModeloDDD.Application;
    using ProjetoModeloDDD.Application.Interface;
    using ProjetoModeloDDD.Domain.Interfaces.Repositories;
    using ProjetoModeloDDD.Domain.Interfaces.Services;
    using ProjetoModeloDDD.Domain.Services;
    using ProjetoModeloDDD.Infra.Data.Repositories;
    using SimpleInjector;
    using SimpleInjector.Integration.Web;
    using SimpleInjector.Integration.Web.Mvc;
    
    public static class SimpleInjectorInitializer
    {
        /// <summary>Initialize the container and register it as MVC3 Dependency Resolver.</summary>
        public static void Initialize()
        {
            var container = new Container();
            container.Options.DefaultScopedLifestyle = new WebRequestLifestyle();
            
            InitializeContainer(container);

            container.RegisterMvcControllers(Assembly.GetExecutingAssembly());
            
            container.Verify();
            
            DependencyResolver.SetResolver(new SimpleInjectorDependencyResolver(container));
        }
     
        private static void InitializeContainer(Container container)
        {

            // For instance:
            // container.Register<IUserRepository, SqlUserRepository>(Lifestyle.Scoped);
            container.Register(typeof(IAppServiceBase<>), typeof(AppServiceBase<>));
            container.Register<IBookAppService, BookAppService>(Lifestyle.Scoped);

            container.Register(typeof(IServiceBase<>), typeof(ServiceBase<>));
            container.Register<IBookService, BookService>(Lifestyle.Scoped);

            container.Register(typeof(IRepositoryBase<>), typeof(RepositoryBase<>));
            container.Register<IBookRepository, BookRepository>(Lifestyle.Scoped);
        }
    }
}