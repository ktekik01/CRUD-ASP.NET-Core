using Microsoft.EntityFrameworkCore;
using StudentPortalWeb.Models.Entities;

namespace StudentPortalWeb.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }

        public DbSet <Student> Students { get; set; }


    }
}
