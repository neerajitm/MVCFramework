using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MVCSolution.Startup))]
namespace MVCSolution
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
