using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(JenkinApp.Startup))]
namespace JenkinApp
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
