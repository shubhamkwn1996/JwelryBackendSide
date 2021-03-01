using JwelryBackendSide.DatabaseLayer.Entity;
using Microsoft.EntityFrameworkCore;

namespace JwelryBackendSide
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<UserLogin>().HasData(
                new UserLogin { UserId = 1, UserName = "shubham", Password = "Shubham", UserType = "normal" },
                 new UserLogin { UserId = 2, UserName = "sridhar", Password = "Sridhar", UserType = "privileged" }
                );
        }

        public DbSet<UserLogin> UserLogin { get; set; }
    }
}
