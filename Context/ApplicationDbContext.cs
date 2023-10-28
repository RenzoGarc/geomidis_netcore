using GeomidisSystem.Models;
using GeomidisSystem.Models.Pais;
using Microsoft.EntityFrameworkCore;
namespace GeomidisSystem.Context
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) {
            
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.HasPostgresExtension("postgis");
        }

        public DbSet<PaisExample> paisExamples { get; set; }
        public DbSet<SpgPsGeometry> spgPsGeoemtrys { get; set; }
        // PAIS
        public DbSet<SpgPsCaratamb> spgPsCaratambs { get; set; }
        public DbSet<SpgPsPuatpias> spgPsPuatpias { get; set; }
        public DbSet<SpgPsSumontam> spgPsSumontam { get; set; }
        public DbSet<SpgPsTambos> spgPsTambos { get; set; }
        public DbSet<SpgPsUnidterr> spgPsUnidterrs { get; set; }

    }
}
