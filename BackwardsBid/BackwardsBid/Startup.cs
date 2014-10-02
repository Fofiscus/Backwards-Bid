using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(BackwardsBid.Startup))]
namespace BackwardsBid
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
