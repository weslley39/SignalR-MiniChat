using Microsoft.Owin;
using Owin;
using Singla_test;

[assembly: OwinStartup(typeof(Startup))]
namespace Singla_test
{
    public class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            // Any connection or hub wire up and configuration should go here
            app.MapSignalR();
        }
    }
}