using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(CS_ASP_054.Startup))]
namespace CS_ASP_054
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
