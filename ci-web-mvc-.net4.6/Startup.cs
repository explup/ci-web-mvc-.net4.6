using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ci_web_mvc_.net4._6.Startup))]
namespace ci_web_mvc_.net4._6
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
