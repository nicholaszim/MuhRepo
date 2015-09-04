using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(SAPNETWFtask.Startup))]
namespace SAPNETWFtask
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
