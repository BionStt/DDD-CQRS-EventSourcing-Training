using System;

namespace Regular.Server.Models
{
    public class RegisterInputModel  
    {
        public RegisterInputModel()
        {
            Id = "";
            Team1 = "";
            Team2 = "";
        }

        public String Id { get; set; }
        public String Team1 { get; set; }
        public String Team2 { get; set; }
    }
}