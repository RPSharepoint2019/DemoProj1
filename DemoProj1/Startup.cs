using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(DemoProj1.Startup))]
namespace DemoProj1
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
