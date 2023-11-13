using NetTopologySuite.Geometries;
using NetTopologySuite;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GeomidisSystem.Models.Cuna_Mas
{
    [Table("spg_cums_cgseacfa", Schema = "espaciales")]
    public class SpgCumsCgseacfa
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int CODOBJ { get; set; }
        public string? COCOGE { get; set; } = null!;
        public string? NOCOGE { get; set; } = null!;
        public string? PRCOGE { get; set; } = null!;
        public DateTime FECCRE { get; set; }
        public int? CANFAM { get; set; } = 0;
        public string? ESTCOM { get; set; } = null!;
        public int? COUNTE { get; set; } = 0;
        public Geometry? IDEASG { get; set; } = null!;
        public Geometry? GEOMTR { get; set; } = null!;
        public string FECREA { get; set; } = null!;
        public string FEMODIF { get; set; } = null!;
        public string FELIMIN { get; set; } = null!;
    }
}