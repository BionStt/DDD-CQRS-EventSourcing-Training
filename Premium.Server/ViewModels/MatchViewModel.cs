using Premium.Read.Dto;

namespace Premium.Server.ViewModels
{
    public class MatchViewModel : ViewModelBase
    {
        public MatchViewModel()
        {
            Current = new MatchInProgress();
            Actions = new MatchAllowedActions();
        }

        public MatchAllowedActions Actions { get; set; }
        public MatchInProgress Current { get; set; }
    }
}
