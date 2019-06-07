using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ReqTrackingModernization.Startup))]
namespace ReqTrackingModernization
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
