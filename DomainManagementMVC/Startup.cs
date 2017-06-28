using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(DomainManagementMVC.Startup))]
namespace DomainManagementMVC
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
