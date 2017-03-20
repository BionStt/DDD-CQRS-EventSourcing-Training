using Premium.Server.ViewModels;

namespace Premium.Server.Application
{
    public class LiveScoreService
    {
        public LiveViewModel GetLiveViewModel()
        {
            var facade = new MatchFacade();
            var model = new LiveViewModel { LiveMatches = facade.FindInProgress() };
            return model;
        }
    }
}