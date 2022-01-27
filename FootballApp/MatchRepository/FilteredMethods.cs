using FootballApp.Models;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Linq;

namespace FootballApp.MatchRepository
{
    public static class FilteredMethods
    {

        // FILTER BY TEAM
        public static List<string> GetMatchesByTeam(string name)
        {
            List<FinishedMatch> finishedGamesData = FinishedMatchReader.GetFinishedMatches().Where(x => x.HomeTeam.Equals(name, System.StringComparison.OrdinalIgnoreCase) || x.AwayTeam.Equals(name, System.StringComparison.OrdinalIgnoreCase)).ToList();
            List<UpComingMatch> upcomingGamesData = UpcomingMatchReader.GetUpcomingMatches().Where(x => x.HomeTeam.Equals(name, System.StringComparison.OrdinalIgnoreCase) || x.AwayTeam.Equals(name, System.StringComparison.OrdinalIgnoreCase)).ToList();

            var JsonCopy_finishedGamesData = new List<string>();
            foreach (var match in finishedGamesData)
            {
                JsonCopy_finishedGamesData.Add(JsonConvert.SerializeObject(match, Formatting.Indented));
            }

            var JsonCopy_upcomingGamesData = new List<string>();
            foreach (var match in upcomingGamesData)
            {
                JsonCopy_upcomingGamesData.Add(JsonConvert.SerializeObject(match, Formatting.Indented));
            }

            var filteredByTeam = new List<string>();

            filteredByTeam = JsonCopy_finishedGamesData;
            filteredByTeam.AddRange(JsonCopy_upcomingGamesData);

            return filteredByTeam; // return filltered list of strings in JSON format

        } // end method GetMatchesByTeam


        //==============================================================================================================

        //FILTER BY TEAM AND STATUS
        public static List<string> GetMatchesByTeamAndStatus(string name, string status)
        {
            List<string> filteredByStatus = new List<string>();

            if (status == "played")
            {
                var finishedGamesData = FinishedMatchReader.GetFinishedMatches().Where(x => x.HomeTeam.Equals(name, System.StringComparison.OrdinalIgnoreCase) || x.AwayTeam.Equals(name, System.StringComparison.OrdinalIgnoreCase));

                var JsonCopy_finishedGamesData = new List<string>();
                foreach (var match in finishedGamesData)
                {
                    JsonCopy_finishedGamesData.Add(JsonConvert.SerializeObject(match));
                }

                filteredByStatus = JsonCopy_finishedGamesData;
            }
            else if (status == "upcoming")
            {
                var upcomingGamesData = UpcomingMatchReader.GetUpcomingMatches().Where(x => x.HomeTeam.Equals(name, System.StringComparison.OrdinalIgnoreCase) || x.AwayTeam.Equals(name, System.StringComparison.OrdinalIgnoreCase));

                var JsonCopy_upcomingGamesData = new List<string>();
                foreach (var match in upcomingGamesData)
                {
                    JsonCopy_upcomingGamesData.Add(JsonConvert.SerializeObject(match));
                }

                filteredByStatus = JsonCopy_upcomingGamesData;
            }

            return filteredByStatus;

        } // end method GetMatchesByTeamAndStatus

        //=============================================================================================================

        // FILTER BY MATCHES TOURNAMENT
        public static List<string> GetMatchesByTournament(string league)
        {
            var finishedGamesData = FinishedMatchReader.GetFinishedMatches().Where(x => x.Tournament.Equals(league, System.StringComparison.OrdinalIgnoreCase));
            var upcomingGamesData = UpcomingMatchReader.GetUpcomingMatches().Where(x => x.Tournament.Equals(league, System.StringComparison.OrdinalIgnoreCase));


            List<string> filteredByTournament = new List<string>();

            var JsonCopy_finishedGamesData = new List<string>();
            foreach (var match in finishedGamesData)
            {
                JsonCopy_finishedGamesData.Add(JsonConvert.SerializeObject(match));
            }

            var JsonCopy_upcomingGamesData = new List<string>();
            foreach (var match in upcomingGamesData)
            {
                JsonCopy_upcomingGamesData.Add(JsonConvert.SerializeObject(match));
            }

            filteredByTournament = JsonCopy_finishedGamesData;
            filteredByTournament.AddRange(JsonCopy_upcomingGamesData);

            return filteredByTournament;

        } // end method GetMatchesByTournament

        ////==============================================================================================================


        // FILTER BY MATCHES TOURNAMENT AND STATUS 
        public static List<string> GetMatchesByTournamentAndStatus(string league, string status)
        {
            List<string> filtered = new List<string>();

            if (status == "played")
            {
                var finishedGamesData = FinishedMatchReader.GetFinishedMatches().Where(x => x.Tournament.Equals(league, System.StringComparison.OrdinalIgnoreCase));

                var JsonCopy_finishedGamesData = new List<string>();
                foreach (var match in finishedGamesData)
                {
                    JsonCopy_finishedGamesData.Add(JsonConvert.SerializeObject(match));
                }

                filtered = JsonCopy_finishedGamesData;
            }

            else if (status == "upcoming")
            {
                var upcomingGamesData = UpcomingMatchReader.GetUpcomingMatches().Where(x => x.Tournament.Equals(league, System.StringComparison.OrdinalIgnoreCase));

                var JsonCopy_upcomingGamesData = new List<string>();
                foreach (var match in upcomingGamesData)
                {
                    JsonCopy_upcomingGamesData.Add(JsonConvert.SerializeObject(match));
                }

                filtered = JsonCopy_upcomingGamesData;
            }

            return filtered;

        } // end method GetMatchesByTournamentAndStatus
    } // end class 
}