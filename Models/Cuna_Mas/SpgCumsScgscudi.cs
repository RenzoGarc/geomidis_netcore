using NetTopologySuite.Geometries;
using NetTopologySuite;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace GeomidisSystem.Models.Cuna_Mas
{
    [Table("spg_cums_scgscudi", Schema = "espaciales")]
    public class SpgCumsScgscudi
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int CODOBJ { get; set; }
        public string FECREA { get; set; } = null!;
        public string FEMODIF { get; set; } = null!;
        public string FELIMIN { get; set; } = null!;
        public string? CSCGSCD { get; set; } = null!;
        public string? NOCOGE { get; set; } = null!;
        public string? PRCOGE { get; set; } = null!;
        public int? PERGES { get; set; } = 0;
        public string? DIRECC { get; set; } = null!;
        public string? REFERE { get; set; } = null!;
        public string? UBIGEO { get; set; } = null!;
        public float? COUBIX { get; set; } = 0;
        public float? COUBIY { get; set; } = 0;
        public Point? IDEASG { get; set; } = null!;
    }
}