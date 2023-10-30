using GeomidisSystem.Models;
using GeomidisSystem.Models.Pais;
using GeomidisSystem.Models.Contigo;
using GeomidisSystem.Models.Cuna_Mas;
using GeomidisSystem.Models.Diseno_Arte;
using GeomidisSystem.Models.Focalizacion;
using GeomidisSystem.Models.Foncodes;
using GeomidisSystem.Models.Juntos;
using GeomidisSystem.Models.Pension;
using GeomidisSystem.Models.Qali_Warma;
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

        //CONTIGO
        public DbSet<SpgCtgUsprocon> spgCtgUsprocon { get; set; }
        public DbSet<SpgCtgVidomusu> spgCtgVidomusu { get; set; }
        //CUNA MAS
        public DbSet<SpgCumsCgseacfa> spgCumsCgseacfa { get; set; }
        public DbSet<SpgCumsCgsecudi> spgCumsCgsecudi { get; set; }
        public DbSet<SpgCumsDistfoca> spgCumsDistfoca { get; set; }
        public DbSet<SpgCumsFrseacfa> spgCumsFrseacfa { get; set; }
        public DbSet<SpgCumsLoceinai> spgCumsLoceinai { get; set; }
        public DbSet<SpgCumsLoserali> spgCumsLoserali { get; set; }
        public DbSet<SpgCumsScgsacfa> spgCumsScgsacfa { get; set; }
        public DbSet<SpgCumsScgscudi> spgCumsScgscudi { get; set; }
        public DbSet<SpgCumsSeuniter> spgCumsSeuniter { get; set; }
        public DbSet<SpgCumsUntecuma> spgCumsUntecuma { get; set; }
        //DISEÑO Y ARTE
        public DbSet<SpgDiseartComepopu> spgDiseartComepopu { get; set; }
        public DbSet<SpgDiseartOllicomu> spgDiseartOllicomu { get; set; }

        //FOCALIZACION
        public DbSet<SpgFclCpdgfi> spgFclCpdgfi { get; set; }
        public DbSet<SpgFclHogdgfis> spgFclHogdgfis { get; set; }

        //FONCODES
        public DbSet<SpgFcdCepohawi> spgFcdCepohawi { get; set; }
        public DbSet<SpgFcdCepomiab> spgFcdCepomiab { get; set; }
        public DbSet<SpgFcdCobhawi> spgFcdCobhawi { get; set; }
        public DbSet<SpgFcdNuejhawi> spgFcdNuejhawi { get; set; }
        public DbSet<SpgFcdPragumas> spgFcdPragumas { get; set; }
        public DbSet<SpgFcdProyinfr> spgFcdProyinfr { get; set; }
        public DbSet<SpgFcdResiestu> spgFcdResiestu { get; set; }
        public DbSet<SpgFcdUnterfon> spgFcdUnterfon { get; set; }
        public DbSet<SpgFcdUsdemiab> spgFcdUsdemiab { get; set; }
        public DbSet<SpgFcdUshakwin> spgFcdUshakwin { get; set; }

        //JUNTOS
        public DbSet<SpgJtsHogajunt> spgJtsHogajunt { get; set; }
        public DbSet<SpgJtsSeuniter> spgJtsSeuniter { get; set; }
        public DbSet<SpgJtsUniterju> spgJtsUniterju { get; set; }

        //PENSION 65
        public DbSet<SpgPsn65Agebanac> spgPsn65Agebanac { get; set; }
        public DbSet<SpgPsn65Emtraval> spgPsn65Emtraval { get; set; }
        public DbSet<SpgPsn65Usupen65> spgPsn65Usupen65 { get; set; }

        //QALI WARMA
        public DbSet<SpgQwAlmaprov> spgQwAlmaprov { get; set; }
        public DbSet<SpgQwEntrprod> spgQwEntrprod { get; set; }
        public DbSet<SpgQwSupeiiee> spgQwSupeiiee { get; set; }
        public DbSet<SpgQwUnteqawa> spgQwUnteqawa { get; set; }

    }
}
