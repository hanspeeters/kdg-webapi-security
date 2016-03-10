using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace SecurityDemo.Controllers
{
    public class TeamsController : ApiController
    {
        [Route("api/teams")]
        public IHttpActionResult Get()
        {
            using (var context = new TeamsContext())
            {
                var teams = context.Teams
                    .Include(x => x.Players)
                    .ToList();

                return Ok(teams);
            }
        }
    }

    public class Team
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Year { get; set; }
        public string Division { get; set; }

        public ICollection<Player> Players  { get; set; }
    }

    public class Player
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public Team Team { get; set; }
    }
}
