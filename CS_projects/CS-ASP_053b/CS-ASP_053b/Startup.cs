using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(CS_ASP_053b.Startup))]
namespace CS_ASP_053b
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
