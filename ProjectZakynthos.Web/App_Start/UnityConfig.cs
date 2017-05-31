using System.Web.Mvc;
using Microsoft.Practices.Unity;
using Unity.Mvc5;
using ProjectZakynthos.Persistence;
using ProjectZakynthos.Persistence.FileSystem;

namespace ProjectZakynthos.Web
{
    public static class UnityConfig
    {
        public static void RegisterComponents()
        {
			var container = new UnityContainer();
                        
            container.RegisterType<IWishlistRepository, WishlistRepository>();
			container.RegisterType<IWishRepository, WishRepository>();

			DependencyResolver.SetResolver(new UnityDependencyResolver(container));
        }
    }
}