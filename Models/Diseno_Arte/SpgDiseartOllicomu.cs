using NetTopologySuite.Geometries;
using NetTopologySuite;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace GeomidisSystem.Models.Diseno_Arte
{
    [Table("spg_diseart_ollicomu", Schema = "espaciales")]
    public class SpgDiseartOllicomu
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int CODOBJ { get; set; }
        public string? FECREA { get; set; } = null!;
        public string? FEMODIF { get; set; } = null!;
        public string? FELIMIN { get; set; } = null!;
        public string? COOLCO { get; set; } = null!;
        public string? NOOLCO { get; set; } = null!;
        public string? DIOLCO { get; set; } = null!;
        public string? UBIGEO { get; set; } = null!;
        public string? COCEPO { get; set; } = null!;
        public string? CENPOB { get; set; } = null!;
        public int? DNIREP { get; set; } = 0;
        public string? NOMREP { get; set; } = null!;
        public string? DIRREP { get; set; } = null!;
        public int? TELREP { get; set; } = 0;
        public string? CORREP { get; set; } = null!;
        public string? ESTOLL { get; set; } = null!;
        public int? CANBEN { get; set; } = 0;
        public float? COUBIX { get; set; } = 0;
        public float? COUBIY { get; set; } = 0;
        public Point? IDEASG { get; set; } = null!;
    }
}