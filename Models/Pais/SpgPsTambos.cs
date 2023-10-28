using NetTopologySuite.Geometries;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GeomidisSystem.Models.Pais
{
    [Table("spg_ps_tambos", Schema = "espaciales")]
    public class SpgPsTambos
    {
        [Key]
        public string CODTAM { get; set; }
        public string? UBITAM { get; set; } = null!;
        public string? UBCEPO { get; set; } = null!;
        public string? DEPART { get; set; } = null!;
        public string? PROVIN { get; set; } = null!;
        public string? DISTRI { get; set; } = null!;
        public string? CENPOB { get; set; } = null!;
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
