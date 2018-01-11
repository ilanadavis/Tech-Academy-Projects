using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(CS_ASP_015.Startup))]
namespace CS_ASP_015
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
