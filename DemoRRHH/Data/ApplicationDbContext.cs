using DemoRRHH.Models.Entities;
using Microsoft.EntityFrameworkCore;

namespace DemoRRHH.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<UserAccount> UserAccounts { get; set; }
    }
}
