using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ChallengeHeroMonsterClassesPart1.Startup))]
namespace ChallengeHeroMonsterClassesPart1
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
