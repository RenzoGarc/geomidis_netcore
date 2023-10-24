using GeomidisSystem.Models;
using Microsoft.EntityFrameworkCore;
namespace GeomidisSystem.Context
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) {
            
        }

        public DbSet<PaisExample> paisExamples { get; set; }
    }
}
