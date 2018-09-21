using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ExemploPortal.Startup))]
namespace ExemploPortal
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
