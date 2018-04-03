using Microsoft.Owin;
using Owin;

[assembly: OwinStartup(typeof(SerhiiFirstProjectService.Startup))]

namespace SerhiiFirstProjectService
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureMobileApp(app);
        }
    }
}