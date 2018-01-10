using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Challenge_First_Papa_Bobs_Pizza.Startup))]
namespace Challenge_First_Papa_Bobs_Pizza
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
