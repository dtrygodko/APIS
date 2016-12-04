using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(APIS.Startup))]
namespace APIS
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
