using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MegaChallengeCasino.Startup))]
namespace MegaChallengeCasino
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
