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
    public static class FinishedMatchReader
    {
        public static List<FinishedMatch> finishedGames = new List<FinishedMatch>();

        public static List<FinishedMatch> GetFinishedMatches()
        {
            if (finishedGames.Count == 0)
            {
                try
                {
                    var config = new CsvConfiguration(CultureInfo.InvariantCulture)
                    {
                        PrepareHeaderForMatch = args => args.Header.ToLower(),
                    };

                    using (var reader = new StreamReader(@"C:\Users\shala\OneDrive\Documents\MinuteMediaAssignment\FootballApp_ShalevHogue\FootballApp\App_Data\result_played.csv"))
                    using (var csv = new CsvReader(reader, config))
                    {

                        csv.Context.RegisterClassMap<FinishedMatchMap>();
                        finishedGames = csv.GetRecords<FinishedMatch>().ToList();
                    }

                }
                catch (Exception e)
                {
                    throw new Exception(e.Message);
                }
            }

            return finishedGames;

        }// end of GetFinishedMatches()
    } // end of class
}