using Deluxe.Server.Application;

namespace Deluxe.Server.Controllers
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