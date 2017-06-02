using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ProjectZakynthos.Web.Startup))]
namespace ProjectZakynthos.Web
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
