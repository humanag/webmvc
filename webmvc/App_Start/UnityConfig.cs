using AutoMapper;
using BAL.Services;
using BAL.Services.Implement;
using DAL;
using System.Web.Mvc;
using Unity;
using Unity.Mvc5;

namespace WebMVC
{
    public static class UnityConfig
    {
        public static void RegisterComponents()
        {
			var container = new UnityContainer();
           
            // register all your components with the container here
            // it is NOT necessary to register your controllers

            // e.g. container.RegisterType<ITestService, TestService>();
            container.RegisterType<IUnitOfWork, UnitOfWork>();
            container.RegisterType<IHomeService, HomeService>();
            container.RegisterType<IProductService, ProductService>();
            container.RegisterType<ICategoryService, CategoryService>();
            container.RegisterType<IBlogCategoryService, BlogCategoryService>();
            container.RegisterType<IBlogService, BlogService>();
            container.RegisterType<IAccountService, AccountService>();
            container.RegisterType<IParamService, ParamService>();

            var mappingConfig = new MapperConfiguration(mc => { mc.AddProfile(new MappingProfile()); });
            IMapper mapper = mappingConfig.CreateMapper();
            container.RegisterInstance(mapper);

            DependencyResolver.SetResolver(new UnityDependencyResolver(container));
        }
    }
}