using System.Web;
using System.Web.Routing;

namespace EventSourcing.Server
{
    public class BookingApplication : HttpApplication
    {
        public static IBus Bus { get; set; }

        protected void Application_Start()
        {
            BusConfig.Initialize();
            RouteConfig.RegisterRoutes(RouteTable.Routes);
        }
    }
}
