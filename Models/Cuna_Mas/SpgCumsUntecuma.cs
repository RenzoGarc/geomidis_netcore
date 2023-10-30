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
        public string COUNTE { get; set; }
        public string? UNITER { get; set; } = null!;
        public int? CACOGE { get; set; } = 0;
        public int? CANFAM { get; set; } = 0;
        public int? CANCOGE { get; set; } = 0;
        public int? CANUSU { get; set; } = 0;
        public int? CANLOC { get; set; } = 0;
        public float? COUBIX { get; set; } = 0;
        public float? COUBIY { get; set; } = 0;
        public Point? IDEASG { get; set; } = null!;
    }
}