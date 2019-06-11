using Microsoft.Owin;
using Owin;

[assembly: OwinStartup(typeof(AzureMobileAppServices.Startup))]

namespace AzureMobileAppServices
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureMobileApp(app);
        }
    }
}