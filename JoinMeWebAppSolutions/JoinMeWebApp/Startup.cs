using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(JoinMeWebApp.Startup))]
namespace JoinMeWebApp
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
