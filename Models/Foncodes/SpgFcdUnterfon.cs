using NetTopologySuite.Geometries;
using NetTopologySuite;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace GeomidisSystem.Models.Foncodes
{
    [Table("spg_fcd_unterfon", Schema = "espaciales")]
    public class SpgFcdUnterfon
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int CODOBJ { get; set; }
        public string? FECREA { get; set; } = null!;
        public string? FEMODIF { get; set; } = null!;
        public string? FELIMIN { get; set; } = null!;
        public string? COUNTE { get; set; } = null!;
        public string? NOUNTE { get; set; } = null!;
        public int? CANDIS { get; set; } = 0;
        public Geometry? GEOMTR { get; set; } = null!;
        public Geometry? IDEASG { get; set; } = null!;
    }
}