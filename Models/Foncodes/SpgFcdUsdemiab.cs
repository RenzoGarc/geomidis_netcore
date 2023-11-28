using NetTopologySuite.Geometries;
using NetTopologySuite;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace GeomidisSystem.Models.Foncodes
{
    [Table("spg_fcd_usdemiab", Schema = "espaciales")]
    public class SpgFcdUsdemiab
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int CODOBJ { get; set; }
        public string? FECREA { get; set; } = null!;
        public string? FEMODIF { get; set; } = null!;
        public string? FELIMIN { get; set; } = null!;
        public int? NDJEHO { get; set; } = 0;
        public string? NOJEHO { get; set; } = null!;
        public string? APJEHO { get; set; } = null!;
        public string? FECNAC { get; set; } = null!;
        public int? CAMIHO { get; set; } = 0;
        public int? PISOHO { get; set; } = 0;
        public int? HABIHO { get; set; } = 0;
        public int? FOTOHO { get; set; } = 0;
        public string? DIREHO { get; set; } = null!;
        public string? COCEPO { get; set; } = null!;
        public string? UBIGEO { get; set; } = null!;
        public string? COUNTE { get; set; } = null!;
        public string? TIPREG { get; set; } = null!;
        public float? COOUBX { get; set; } = 0;
        public float? COOUBY { get; set; } = 0;
        public Point? IDEASG { get; set; } = null!;
        
    }
}