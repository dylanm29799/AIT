using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Liverpool.Startup))]
namespace Liverpool
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
