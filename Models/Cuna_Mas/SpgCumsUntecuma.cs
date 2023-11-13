using NetTopologySuite.Geometries;
using NetTopologySuite;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace GeomidisSystem.Models.Cuna_Mas
{
    [Table("spg_cums_untecuma", Schema = "espaciales")]
    public class SpgCumsUntecuma
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int CODOBJ { get; set; }
        public string FECREA { get; set; } = null!;
        public string FEMODIF { get; set; } = null!;
        public string FELIMIN { get; set; } = null!;
        public string? COUNTE { get; set; } = null!;
        public string? UNITER { get; set; } = null!;
        public int? CACOGE { get; set; } = 0;
        public int? CANFAM { get; set; } = 0;
        public int? CANCOGE { get; set; } = 0;
        public int? CANUSU { get; set; } = 0;
        public int? CANLOC { get; set; } = 0;
        public Geometry? IDEASG { get; set; } = null!;
        public Geometry? GEOMTR { get; set; } = null!;
    }
}