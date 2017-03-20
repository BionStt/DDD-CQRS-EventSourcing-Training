using System.Collections.Generic;

namespace Deluxe.Server.ViewModels
{
    public class IndexViewModel : ViewModelBase
    {
        public IList<CourtSchedule> CourtSchedules { get; set; }
    }
}