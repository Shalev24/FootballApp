using CsvHelper.Configuration;
using FootballApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FootballApp.Mappers
{
    public class FinishedMatchMap : ClassMap<FinishedMatch>
    {
        public FinishedMatchMap()
        {
            Map(x => x.HomeTeam).Name("home_team");
            Map(x => x.HomeScore).Name("home_score");
            Map(x => x.AwayTeam).Name("away_team");
            Map(x => x.AwayScore).Name("away_score");
            Map(x => x.Tournament).Name("tournament");
            Map(x => x.StartTime).Name("start_time");
        }
    }
}