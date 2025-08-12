using HRSolutions.Models;
using Microsoft.EntityFrameworkCore;

namespace HRSolutions.Data
{
    public class ApplicationDbContext: DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options) { }
        public DbSet<Login> Login { get; set; }
        public DbSet<Employee> Employee { get; set; }
        public DbSet<Notice> Notice { get; set; }
        public DbSet<Announcement>Announcement { get; set; }
        public DbSet<View>View { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<View>() // Replace 'View' with your actual class name
                .HasNoKey()
                .ToView(null); // Optional: if you're not using a mapped DB view name
        }
        

    }
}
