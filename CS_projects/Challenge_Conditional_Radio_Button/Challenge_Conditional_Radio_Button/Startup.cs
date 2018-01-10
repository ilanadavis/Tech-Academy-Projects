using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Challenge_Conditional_Radio_Button.Startup))]
namespace Challenge_Conditional_Radio_Button
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
