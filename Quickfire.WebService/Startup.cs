using Microsoft.Owin;
using Owin;

[assembly: OwinStartup(typeof(quickfireService.Startup))]

namespace quickfireService
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureMobileApp(app);
        }
    }
}