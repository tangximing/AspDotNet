using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(loginForms.Startup))]
namespace loginForms
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
