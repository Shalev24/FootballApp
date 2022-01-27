using FootballApp.MatchRepository;
using System.Collections.Generic;
using System.Web.Http;

namespace FootballApp.Controllers
{
    [RoutePrefix("api/teams")]
    public class TeamsController : ApiController
    {
        // GET: api/teams/teamname
        [Route("{team}")]
        public List<string> GetTeam(string team)
        {
            return FilteredMethods.GetMatchesByTeam(team);
        }

        // GET: api/teams/teamname/status
        [Route("{team}/{status}")]
        public List<string> GetTeamAndStatus(string team, string status)
        {
            return FilteredMethods.GetMatchesByTeamAndStatus(team, status);
        }
    }
}
