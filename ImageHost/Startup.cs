using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ImageHost.Startup))]
namespace ImageHost
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
