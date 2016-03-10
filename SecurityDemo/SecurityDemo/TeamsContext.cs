using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using SecurityDemo.Controllers;

namespace SecurityDemo
{
    public class TeamsContext : DbContext
    {
        public TeamsContext()
            : base("DefaultConnection")
        {
        }

        public IDbSet<Team> Teams { get; set; }
        public IDbSet<Player> Players { get; set; }
    }
}