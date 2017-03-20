using Premium.Server.ViewModels;

namespace Premium.Server.Application
{
    public class HomeService
    {
        public IndexViewModel GetIndexViewModel()
        {
            var facade = new MatchFacade();
            var model = new IndexViewModel { ScheduledMatches = facade.FindScheduled() };
            return model;
        }
    }
}