using NetTopologySuite.Geometries;
using NetTopologySuite;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace GeomidisSystem.Models.Qali_Warma
{
    [Table("spg_qw_almaprov", Schema = "espaciales")]
    public class SpgQwAlmaprov
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public string COALPR { get; set; }
        public string? NOMPRO { get; set; } = null!;
        public string? DIRECC { get; set; } = null!;
        public string? DEPART { get; set; } = null!;
        public string? PROVIN { get; set; } = null!;
        public string? DISTRI { get; set; } = null!;
        public float? COUBIX { get; set; } = 0;
        public float? COUBIY { get; set; } = 0;
        public string? CAMPAN { get; set; } = null!;
        public string? PROCOM { get; set; } = null!;
        public Point? IDEASG { get; set; } = null!;
    }
}