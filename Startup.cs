using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(TALLER.Startup))]
namespace TALLER
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
