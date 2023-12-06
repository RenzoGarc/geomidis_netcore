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
        public int CODOBJ { get; set; }
        public string? FECREA { get; set; } = null!;
        public string? FEMODIF { get; set; } = null!;
        public string? FELIMIN { get; set; } = null!;
        public string? CODHOG { get; set; } = null!;
        public string? NOMTIT { get; set; } = null!;
        public int? DNITIT { get; set; } = 0;
        public string? DIRECC { get; set; } = null!;
        public string? REFERE { get; set; } = null!;
        public string? CELULA { get; set; } = null!;
        public string? UBIGEO { get; set; } = null!;
        public string? COCEPO { get; set; } = null!;
        public string? CENPOB { get; set; } = null!;
        public string? COUNTE { get; set; } = null!;
        public float? COUBIX { get; set; } = 0;
        public float? COUBIY { get; set; } = 0;
        public bool? b_activo { get; set; } = true;
        public Point? IDEASG { get; set; } = null!;
    }
}