using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(replic_x.Startup))]
namespace replic_x
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
