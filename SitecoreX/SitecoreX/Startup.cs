using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(SitecoreX.Startup))]
namespace SitecoreX
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
