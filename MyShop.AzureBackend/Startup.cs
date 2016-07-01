using Microsoft.Owin;
using Owin;

[assembly: OwinStartup(typeof(supertasksService.Startup))]

namespace supertasksService
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureMobileApp(app);
        }
    }
}