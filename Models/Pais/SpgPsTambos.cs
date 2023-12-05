using NetTopologySuite.Geometries;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GeomidisSystem.Models.Pais
{
    [Table("spg_ps_tambos", Schema = "espaciales")]
    public class SpgPsTambos
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int CODOBJ { get; set; }
        public string FECREA { get; set; } = null!;
        public string FEMODIF { get; set; } = null!;
        public string FELIMIN { get; set; } = null!;
        public string CODTAM { get; set; } = null!;
        public string? COCEPO { get; set; } = null!;
        public string? CENPOB { get; set; } = null!;
        public string? UBIGEO { get; set; } = null!;
        public string? NOMTAM { get; set; } = null!;
        public int? CANPOB { get; set; } = 0;
        public int? CANVIV { get; set; } = 0;
        public string? SNIPTA { get; set; } = null!;
        public string? CUITAM { get; set; } = null!;
        public string? OBSERV { get; set; } = null!;
        public int? COUNTE { get; set; } = 0;
        public float? COUBIX { get; set; } = 0;
        public float? COUBIY { get; set; } = 0;
        public Point? IDEASG { get; set; } = null!;
    }
}
