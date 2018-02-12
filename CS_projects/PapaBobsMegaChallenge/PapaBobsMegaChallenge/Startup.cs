using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(PapaBobsMegaChallenge.Startup))]
namespace PapaBobsMegaChallenge
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
