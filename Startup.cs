using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(cs390914_MIS_SD.Startup))]
namespace cs390914_MIS_SD
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
