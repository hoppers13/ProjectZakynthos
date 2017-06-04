using System.Web.Mvc;
using Microsoft.Practices.Unity;
using Unity.Mvc5;
using ProjectZakynthos.Persistence;
using ProjectZakynthos.Persistence.FileSystem;
using ProjectZakynthos.Web.Controllers;

namespace ProjectZakynthos.Web
{
    public static class UnityConfig
    {
        public static void RegisterComponents()
        {
			var container = new UnityContainer();

            // login
            container.RegisterType<AccountController>(new InjectionConstructor());
            container.RegisterType<ManageController>(new InjectionConstructor());
            
            // wishlist
            container.RegisterType<IWishlistRepository, WishlistRepository>();
			container.RegisterType<IWishRepository, WishRepository>();

			DependencyResolver.SetResolver(new UnityDependencyResolver(container));
        }
    }
}