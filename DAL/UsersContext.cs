using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Sklep_internetowy.Models;

namespace Sklep_internetowy.DAL
{
    public class UsersContext : IdentityDbContext<AppUser, AppRole, int>
    {
        public UsersContext(DbContextOptions<UsersContext> options) : base(options)
        {


        }
    }
}
