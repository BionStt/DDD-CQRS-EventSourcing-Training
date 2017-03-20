using System.Web.Mvc;
using Premium.Server.Application;

namespace Premium.Server.Controllers
{
    public class LiveController : Controller
    {
        private readonly LiveScoreService _liveScoreService = new LiveScoreService();

        public ActionResult Index()
        {
            var model = _liveScoreService.GetLiveViewModel();
            return View(model);
        }

        public PartialViewResult Update()
        {
            var model = _liveScoreService.GetLiveViewModel();
            return PartialView("_live", model);
        }
    }
}