using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(HrTrack.Startup))]
namespace HrTrack
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
