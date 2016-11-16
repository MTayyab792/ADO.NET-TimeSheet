using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Computan.Timesheet.v2.Startup))]
namespace Computan.Timesheet.v2
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
