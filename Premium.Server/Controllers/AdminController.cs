using System.Web.Mvc;
using Premium.Server.Application;
using Premium.Server.Common.Actions;
using Premium.Server.ViewModels;

namespace Premium.Server.Controllers
{
    public class AdminController : Controller
    {
        private readonly AdminService _adminService = new AdminService();

        public ActionResult Index()
        {
            var model = new ViewModelBase();
            return View(model);
        }

        [HttpPost]
        public ActionResult Action(AdminAction action)
        {
            _adminService.ProcessAction(action);
            return RedirectToAction("index", "home");
        }
    }
}