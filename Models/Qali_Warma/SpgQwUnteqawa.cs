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
        public int CODOBJ { get; set; }
        public string? FECREA { get; set; } = null!;
        public string? FEMODIF { get; set; } = null!;
        public string? FELIMIN { get; set; } = null!;
        public string? COUNTE { get; set; } = null!;
        public string? NOUNTE { get; set; } = null!;
        public int? CANALM { get; set; } = 0;
        public int? CACEED { get; set; } = 0;
        public string? JEUNTE { get; set; } = null!;
        public string? DIRECC { get; set; } = null!;
        public Geometry? GEOMTR { get; set; } = null!;
        public Geometry? IDEASG { get; set; } = null!;
    }
}