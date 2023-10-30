using NetTopologySuite.Geometries;
using NetTopologySuite;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace GeomidisSystem.Models.Juntos
{
    [Table("spg_jts_uniterju", Schema = "espaciales")]
    public class SpgJtsUniterju
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int COUNTE { get; set; }
        public string? NOMUT { get; set; } = null!;
        public int? CANPOB { get; set; } = 0;
        public string? NUMIOB { get; set; } = null!;
        public string? NUHOAB { get; set; } = null!;
        public float? COUBIX { get; set; } = 0;
        public float? COUBIY { get; set; } = 0;
        public Point? IDEASG { get; set; } = null!;
    }
}