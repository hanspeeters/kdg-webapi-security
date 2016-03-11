using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using System.Web;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using SecurityDemo.Controllers;

namespace SecurityDemo
{
    public class TeamsContext : IdentityDbContext<ApplicationUser>
    {
        public TeamsContext()
            : base("DefaultConnection")
        {
        }

        public IDbSet<Team> Teams { get; set; }
        public IDbSet<Player> Players { get; set; }

        public static TeamsContext Create()
        {
            return new TeamsContext();
        }
    }

    public class ApplicationUser : IdentityUser
    {
        public string FavoriteTeam { get; set; }

        public async Task<ClaimsIdentity> GenerateUserIdentityAsync(UserManager<ApplicationUser> manager, string authenticationType)
        {
            // Note the authenticationType must match the one defined in CookieAuthenticationOptions.AuthenticationType
            var userIdentity = await manager.CreateIdentityAsync(this, authenticationType);
            // Add custom user claims here
            return userIdentity;
        }
    }
}