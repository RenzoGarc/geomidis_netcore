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
        public string CODPRO { get; set; }
        public string? NOMPRO { get; set; } = null!;
        public int? NUCEED { get; set; } = 0;
        public string? NOMCOL { get; set; } = null!;
        public string? ESTAPR { get; set; } = null!;
        public string? NIREES { get; set; } = null!;
        public string? CAREES { get; set; } = null!;
        public string? DIREES { get; set; } = null!;
        public string? DEREES { get; set; } = null!;
        public string? PRREES { get; set; } = null!;
        public string? DISREES { get; set; } = null!;
        public string? CENPOB { get; set; } = null!;
        public int? CAALBE { get; set; } = 0;
        public int? CANALU { get; set; } = 0;
        public int? CANDOC { get; set; } = 0;
        public DateTime FECINI { get; set; }
        public DateTime FECTER { get; set; }
        public DateTime FECPRO { get; set; }
        public string? UBREES { get; set; } = null!;
        public float? COOUBX { get; set; } = 0;
        public float? COOUBY { get; set; } = 0;
        public Point? IDEASG { get; set; } = null!;
    }
}