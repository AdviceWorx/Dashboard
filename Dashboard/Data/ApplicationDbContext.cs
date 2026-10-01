using Dashboard.Models;
using Microsoft.EntityFrameworkCore;

namespace Dashboard.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(
            DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<UserActivity> UserActivities { get; set; }
    }
}