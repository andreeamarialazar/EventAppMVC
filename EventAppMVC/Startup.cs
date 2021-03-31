using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(EventAppMVC.Startup))]
namespace EventAppMVC
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
