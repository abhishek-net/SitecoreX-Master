using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(SitecoreX_1.Startup))]
namespace SitecoreX_1
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
