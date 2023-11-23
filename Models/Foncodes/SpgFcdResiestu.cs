using NetTopologySuite.Geometries;
using NetTopologySuite;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace GeomidisSystem.Models.Foncodes
{
    [Table("spg_fcd_resiestu", Schema = "espaciales")]
    public class SpgFcdResiestu
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int CODOBJ { get; set; }
        public string? FECREA { get; set; } = null!;
        public string? FEMODIF { get; set; } = null!;
        public string? FELIMIN { get; set; } = null!;
        public string? CODPRO { get; set; } = null!;
        public string? NOMPRO { get; set; } = null!;
        public int? NUCEED { get; set; } = 0;
        public string? NOMCOL { get; set; } = null!;
        public string? ESTAPR { get; set; } = null!;
        public string? NIREES { get; set; } = null!;
        public string? CAREES { get; set; } = null!;
        public string? DIREES { get; set; } = null!;
        public string? UBIGEO { get; set; } = null!;
        public string? COCEPO { get; set; } = null!;
        public int? CAALBE { get; set; } = 0;
        public int? CANALU { get; set; } = 0;
        public int? CANDOC { get; set; } = 0;
        public string? FECINI { get; set; } = null!;
        public string? FECTER { get; set; } = null!;
        public string? FECPRO { get; set; } = null!;
        public float? COOUBX { get; set; } = 0;
        public float? COOUBY { get; set; } = 0;
        public Point? IDEASG { get; set; } = null!;
    }
}