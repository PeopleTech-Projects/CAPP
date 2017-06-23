using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(CAPP.Web.Startup))]
namespace CAPP.Web
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
