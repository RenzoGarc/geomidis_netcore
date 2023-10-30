using NetTopologySuite.Geometries;
using NetTopologySuite;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace GeomidisSystem.Models.Cuna_Mas
{
    [Table("spg_cums_cgsecudi", Schema = "espaciales")]
    public class SpgCumsCgsecudi
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public string COCOGE { get; set; }
        public string? NOCOGE { get; set; } = null!;
        public int? CLOSDC { get; set; } = 0;
        public string? ESTCOM { get; set; } = null!;
        public int? COUNTE { get; set; } = 0;
        public float? COUBIX { get; set; } = 0;
        public float? COUBIY { get; set; } = 0;
        public Point? IDEASG { get; set; } = null!;
    }
}