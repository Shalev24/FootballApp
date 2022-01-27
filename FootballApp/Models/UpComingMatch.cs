using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FootballApp.Models
{
    public class UpComingMatch
    {
        public string HomeTeam { get; set; }
        public string AwayTeam { get; set; }
        public string Tournament { get; set; }
        public string StartTime { get; set; }
        public string KickOff { get; set; }
        
    }
}