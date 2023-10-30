using NetTopologySuite.Geometries;
using NetTopologySuite;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace GeomidisSystem.Models.Foncodes
{
    [Table("spg_fcd_usdemiab", Schema = "espaciales")]
    public class SpgFcdUsdemiab
    {
        public int? CANPOB { get; set; } = 0;
        public string? NOJEHO { get; set; } = null!;
        public string? APJEHO { get; set; } = null!;
        public DateTime FECNAC { get; set; }
        public int? CAMIHO { get; set; } = 0;
        public int? PISOHO { get; set; } = 0;
        public int? HABIHO { get; set; } = 0;
        public int? FOTOHO { get; set; } = 0;
        public string? DIREHO { get; set; } = null!;
        public string? COUNTE { get; set; } = null!;
        public string? TIPREG { get; set; } = null!;
        public float? COOUBX { get; set; } = 0;
        public float? COOUBY { get; set; } = 0;
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int id { get; set; }
        public Point? IDEASG { get; set; } = null!;
        public string? CEPOHO { get; set; } = null!;
        public string? DISHOG { get; set; } = null!;
        public string? PROHOG { get; set; } = null!;
        public string? DEPHOG { get; set; } = null!;
    }
}