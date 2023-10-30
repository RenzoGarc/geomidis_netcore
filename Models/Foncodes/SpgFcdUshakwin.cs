using NetTopologySuite.Geometries;
using NetTopologySuite;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace GeomidisSystem.Models.Foncodes
{
    [Table("spg_fcd_ushakwin", Schema = "espaciales")]
    public class SpgFcdUshakwin
    {
        public int? DNJEHO { get; set; } = 0;
        public string? NOJEHO { get; set; } = null!;
        public string? OCJEHO { get; set; } = null!;
        public int? FOTOS5 { get; set; } = 0;
        public int? NUPIHO { get; set; } = 0;
        public int? CAHAHO { get; set; } = 0;
        public string? DIRHOG { get; set; } = null!;
        public string? CENPOB { get; set; } = null!;
        public string? DISTRI { get; set; } = null!;
        public string? PROVIN { get; set; } = null!;
        public string? DEPART { get; set; } = null!;
        public string? TIPPRO { get; set; } = null!;
        public float? MOINPR { get; set; } = 0;
        public int? DNIYAC { get; set; } = 0;
        public string? NOMYAC { get; set; } = null!;
        public string? NUEJCE { get; set; } = null!;
        public string? COUNTE { get; set; } = null!;
        public string? TIPREG { get; set; } = null!;
        public float? COUBIX { get; set; } = 0;
        public float? COUBIY { get; set; } = 0;
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int id { get; set; }
        public Point? IDEASG { get; set; } = null!;
    }
}