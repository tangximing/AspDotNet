using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(loginLdap.Startup))]
namespace loginLdap
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
