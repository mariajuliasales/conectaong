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
    }
}
