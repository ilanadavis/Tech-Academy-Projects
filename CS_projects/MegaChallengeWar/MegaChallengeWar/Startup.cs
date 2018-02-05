using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MegaChallengeWar.Startup))]
namespace MegaChallengeWar
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
