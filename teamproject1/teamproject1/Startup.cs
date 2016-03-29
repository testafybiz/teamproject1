using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(teamproject1.Startup))]
namespace teamproject1
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
