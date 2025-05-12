using conectaOng.Models.Entities;
using Microsoft.EntityFrameworkCore;

namespace conectaOng.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options): base(options)
        {
            
        }

        public DbSet<User> User { get; set; }

        public DbSet<Volunteer> Volunteer { get; set; }

        public DbSet<Organization> Organization { get; set; }

        public DbSet<Event> Event { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Organization>()
                .HasOne(o => o.User) 
                .WithOne(u => u.Organization)
                .HasForeignKey<Organization>(o => o.UserId)
                .OnDelete(DeleteBehavior.Cascade);

            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Volunteer>()
                .HasOne(o => o.User)
                .WithOne(u => u.Volunteer)
                .HasForeignKey<Volunteer>(o => o.UserId)
                .OnDelete(DeleteBehavior.Cascade);

          
        }
    }
}
