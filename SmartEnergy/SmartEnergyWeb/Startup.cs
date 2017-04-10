using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(SmartEnergyWeb.Startup))]
namespace SmartEnergyWeb
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
