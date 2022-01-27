using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using CsvHelper.Configuration;
using CsvHelper.Configuration.Attributes;

namespace FootballApp.Models
{
    public class FinishedMatch
    {
        public string HomeTeam { get; set; }
        public string HomeScore { get; set; }
        public string AwayTeam { get; set; }
        public string AwayScore { get; set; }
        public string Tournament { get; set; }
        public string StartTime { get; set; }
    }
}

