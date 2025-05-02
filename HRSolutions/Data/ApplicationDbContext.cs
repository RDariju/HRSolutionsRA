using HRSolutions.Models;
using Microsoft.EntityFrameworkCore;

namespace HRSolutions.Data
{
    public class ApplicationDbContext: DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options) { }

        public DbSet<Employee> Employee { get; set; }
    }
}
