using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(GITSample.Startup))]
namespace GITSample
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
