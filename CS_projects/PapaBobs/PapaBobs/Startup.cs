using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(PapaBobs.Startup))]
namespace PapaBobs
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
