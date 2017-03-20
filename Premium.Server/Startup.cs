using Microsoft.Owin;
using Premium.Server;
using Owin;

[assembly: OwinStartup(typeof(Startup))]

namespace Premium.Server
{
    public class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            app.MapSignalR();
        }
    }
}
