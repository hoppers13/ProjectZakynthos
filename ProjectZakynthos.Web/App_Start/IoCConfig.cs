using Microsoft.Practices.Unity;
using ProjectZakynthos.Persistence;
using ProjectZakynthos.Persistence.FileSystem;
using System.Web.Http;

namespace ProjectZakynthos.Web
{
    public class IoCConfig
    {
        public static void Register(HttpConfiguration config)
        {
            var container = new UnityContainer();
            container.RegisterType<IItemRepository, ItemRepository>(new HierarchicalLifetimeManager());
            config.DependencyResolver = new UnityResolver(container);
        }
    }
}