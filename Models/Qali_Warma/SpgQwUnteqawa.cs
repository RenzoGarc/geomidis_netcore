using NetTopologySuite.Geometries;
using NetTopologySuite;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace GeomidisSystem.Models.Qali_Warma
{
    [Table("spg_qw_unteqawa", Schema = "espaciales")]
    public class SpgQwUnteqawa
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public string COUNTE { get; set; }
        public string? NOUNTE { get; set; } = null!;
        public int? CANALM { get; set; } = 0;
        public int? CACEED { get; set; } = 0;
        public string? JEUNTE { get; set; } = null!;
        public string? DIRECC { get; set; } = null!;
        public float? COUBIX { get; set; } = 0;
        public float? COUBIY { get; set; } = 0;
        public Point? IDEASG { get; set; } = null!;
    }
}