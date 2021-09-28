using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(BunproApp.Startup))]
namespace BunproApp
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
