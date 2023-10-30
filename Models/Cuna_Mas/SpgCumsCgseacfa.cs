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
        public string COCOGE { get; set; }
        public string? NOCOGE { get; set; } = null!;
        public string? PRCOGE { get; set; } = null!;
        public DateTime FECCRE { get; set; }
        public int? CANFAM { get; set; } = 0;
        public string? ESTCOM { get; set; } = null!;
        public int? COUNTE { get; set; } = 0;
        public float? COUBIX { get; set; } = 0;
        public float? COUBIY { get; set; } = 0;
        public Point? IDEASG { get; set; } = null!;
    }
}