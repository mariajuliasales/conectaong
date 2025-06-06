using conectaOng.Models.Entities;
using Microsoft.EntityFrameworkCore;

namespace conectaOng.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }

        public DbSet<Vacancy> Vacancy { get; set; }
        public DbSet<Event> Event { get; set; }
        public DbSet<Volunteer> Volunteer { get; set; }
        public DbSet<Organization> Organization { get; set; }
        public DbSet<User> User { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
    }
}
