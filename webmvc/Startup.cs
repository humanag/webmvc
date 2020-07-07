using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(webmvc.Startup))]
namespace webmvc
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
