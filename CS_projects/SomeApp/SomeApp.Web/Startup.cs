using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(SomeApp.Web.Startup))]
namespace SomeApp.Web
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
