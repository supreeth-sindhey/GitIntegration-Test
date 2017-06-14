using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(GitIntegration_Test.Startup))]
namespace GitIntegration_Test
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
