using System.Collections.Generic;
using Premium.Read.Dto;

namespace Premium.Server.ViewModels
{
    public class IndexViewModel : ViewModelBase
    {
        public IList<MatchListItem> ScheduledMatches { get; set; }
    }
}
