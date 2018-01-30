using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ChallengeSimpleDarts.Startup))]
namespace ChallengeSimpleDarts
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
