using System;
using System.Collections.Generic;
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
            return Ok(new Team
            {
                Id = 1,
                Name = "Lierse",
                Players = new List<Player>
                {
                    new Player {Id = 1, FirstName = "Jos", LastName = "De vos"}
                }
            });
        }
    }

    public class Team
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public IEnumerable<Player> Players  { get; set; }
    }

    public class Player
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public Team Team { get; set; }
    }
}
