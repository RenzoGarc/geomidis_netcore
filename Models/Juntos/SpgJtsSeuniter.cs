using NetTopologySuite.Geometries;
using NetTopologySuite;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace GeomidisSystem.Models.Juntos
{
    [Table("spg_jts_seuniter", Schema = "espaciales")]
    public class SpgJtsSeuniter
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int CODOBJ { get; set; }
        public string? FECREA { get; set; } = null!;
        public string? FEMODIF { get; set; } = null!;
        public string? FELIMIN { get; set; } = null!;
        public string? COUNTE { get; set; } = null!;
        public string? JEUNTE { get; set; } = null!;
        public int? TEUNTE { get; set; } = 0;
        public string? DIRECC { get; set; } = null!;
        public string? UBIGEO { get; set; } = null!;
        public float? COUBIX { get; set; } = 0;
        public float? COUBIY { get; set; } = 0;
        public Point? IDEASG { get; set; } = null!;
    }
}