using FootballApp.MatchRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace FootballApp.Controllers
{ 

    [RoutePrefix("api/tournaments")]
    public class TournamentsController : ApiController
    {
        // GET: api/tournament/fa or premier-league
        //[HttpGet]
        [Route("{tour}")]
        public List<string> GetTournament(string tour)
        {
            return FilteredMethods.GetMatchesByTournament(tour);
        }


        // GET: api/tournament/tour/status
        //[HttpGet]
        [Route("{tour}/{status}")]
        public List<string> GetTournamentAndStatus(string tour, string status)
        {
            return FilteredMethods.GetMatchesByTournamentAndStatus(tour, status);
        }
    }
}
