using System;
using System.Collections.Generic;

namespace Regular.Server.Models
{
    public class RegisterViewModel : ViewModelBase
    {
        public RegisterViewModel()
        {
            Id = "";
            Team1 = "";
            Team2 = "";
            Matches = new List<Match>();
        }

        public IList<Match> Matches { get; set; }
        public String Team1 { get; set; }
        public String Team2 { get; set; }
        public String Id { get; set; }
    }
}