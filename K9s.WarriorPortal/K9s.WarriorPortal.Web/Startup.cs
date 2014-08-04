using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(K9s.WarriorPortal.Web.Startup))]
namespace K9s.WarriorPortal.Web
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
