using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(OrganikBesinlerMVC.Startup))]
namespace OrganikBesinlerMVC
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
