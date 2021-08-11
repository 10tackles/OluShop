using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(OluShop.WebUI.Startup))]
namespace OluShop.WebUI
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
