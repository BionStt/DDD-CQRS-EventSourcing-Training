using System.Collections.Generic;
using Premium.Read.Dto;

namespace Premium.Server.ViewModels
{
    public class LiveViewModel : ViewModelBase
    {
        public LiveViewModel()
        {
            LiveMatches = new List<MatchInProgress>();
        }

        public IList<MatchInProgress> LiveMatches { get; set; }
    }
}
