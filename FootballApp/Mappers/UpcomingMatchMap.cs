using CsvHelper.Configuration;
using FootballApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FootballApp.Mappers
{
    public class UpcomingMatchMap : ClassMap<UpComingMatch>
    {
        public UpcomingMatchMap()
        {
            Map(x => x.HomeTeam).Name("home_team");
            Map(x => x.AwayTeam).Name("away_team");
            Map(x => x.Tournament).Name("tournament");
            Map(x => x.StartTime).Name("start_time");
            Map(x => x.KickOff).Name("kickoff");

        }
    }
}