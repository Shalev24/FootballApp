 using CsvHelper;
using CsvHelper.Configuration;
using FootballApp.Mappers;
using FootballApp.Models;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
namespace FootballApp.MatchRepository
{
    public static class UpcomingMatchReader
    {
        public static List<UpComingMatch> upcomingGames = new List<UpComingMatch>();
        public static List<UpComingMatch> GetUpcomingMatches()
        {
            if (upcomingGames.Count == 0)
            {
                try
                {
                    var config = new CsvConfiguration(CultureInfo.InvariantCulture)
                    {
                        PrepareHeaderForMatch = args => args.Header.ToLower(),
                    };
                    
                    // Reads stream of data from csv file and stores in StramReader object called "reader" 
                    using (var reader = new StreamReader(@"C:\Users\shala\OneDrive\Documents\MinuteMediaAssignment\FootballApp_ShalevHogue\FootballApp\App_Data\result_upcoming.csv"))

                    using (var csv = new CsvReader(reader , config)) // 
                    {
                        csv.Context.RegisterClassMap<UpcomingMatchMap>();
                        upcomingGames = csv.GetRecords<UpComingMatch>().ToList();
                    }

                }
                catch (Exception e)
                {
                    throw new Exception(e.Message);
                }
            }

            return upcomingGames;
        } //end of GetUpcomingMatches()
    } // end of class
}