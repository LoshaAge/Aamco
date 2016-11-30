using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(AAMCO.Startup))]
namespace AAMCO
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
