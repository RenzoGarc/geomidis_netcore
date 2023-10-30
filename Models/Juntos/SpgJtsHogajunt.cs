using NetTopologySuite.Geometries;
using NetTopologySuite;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GeomidisSystem.Models.Juntos
{
    [Table("spg_jts_hogajunt", Schema = "espaciales")]
    public class SpgJtsHogajunt
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public string CODHOG { get; set; }
        public string? NOMTIT { get; set; } = null!;
        public int? DNITIT { get; set; } = 0;
        public string? DIRECC { get; set; } = null!;
        public string? REFERE { get; set; } = null!;
        public string? CELULA { get; set; } = null!;
        public int? UBIGEO { get; set; } = 0;
        public string? DEPART { get; set; } = null!;
        public string? PROVIN { get; set; } = null!;
        public string? DISTRI { get; set; } = null!;
        public string? CENPOB { get; set; } = null!;
        public string? COUNTE { get; set; } = null!;
        public float? COUBIX { get; set; } = 0;
        public float? COUBIY { get; set; } = 0;
        public Point? IDEASG { get; set; } = null!;
    }
}