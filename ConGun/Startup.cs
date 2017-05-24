using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ConGun.Startup))]
namespace ConGun
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
