using EventSourcing.Server.Application;

namespace EventSourcing.Server.Controllers
{
    public class HomeController : Controller
    {
        private readonly HomeService _homeService = new HomeService();

        public ActionResult Index()
        {
            var model = _homeService.GetIndexViewModel();
            return View(model);
        }
    }
}