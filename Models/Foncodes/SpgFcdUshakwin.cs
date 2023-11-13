using NetTopologySuite.Geometries;
using NetTopologySuite;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace GeomidisSystem.Models.Foncodes
{
    [Table("spg_fcd_ushakwin", Schema = "espaciales")]
    public class SpgFcdUshakwin
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int CODOBJ { get; set; }
        public string FECREA { get; set; } = null!;
        public string FEMODIF { get; set; } = null!;
        public string FELIMIN { get; set; } = null!;
        public int? DNJEHO { get; set; } = 0;
        public string? NOJEHO { get; set; } = null!;
        public string? OCJEHO { get; set; } = null!;
        public int? FOTOS5 { get; set; } = 0;
        public string? COCEPO { get; set; } = null!;
        public string? UBIGEO { get; set; } = null!;
        public string? TIPPRO { get; set; } = null!;
        public float? MOINPR { get; set; } = 0;
        public int? DNIYAC { get; set; } = 0;
        public string? NOMYAC { get; set; } = null!;
        public string? NUEJCE { get; set; } = null!;
        public string? COUNTE { get; set; } = null!;
        public string? TIPREG { get; set; } = null!;
        public float? COUBIX { get; set; } = 0;
        public float? COUBIY { get; set; } = 0;
        public Point? IDEASG { get; set; } = null!;
    }
}