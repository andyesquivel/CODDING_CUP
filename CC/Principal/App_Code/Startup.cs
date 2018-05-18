using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Principal.Startup))]
namespace Principal
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
