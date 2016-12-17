using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(AssetTrakingSystemApp.Startup))]
namespace AssetTrakingSystemApp
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
