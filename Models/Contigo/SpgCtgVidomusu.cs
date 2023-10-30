using NetTopologySuite.Geometries;
using NetTopologySuite;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace GeomidisSystem.Models.Contigo
{
    [Table("spg_ctg_vidomusu", Schema = "espaciales")]
    public class SpgCtgVidomusu
    {
        public int? TIPDOC { get; set; } = 0;
        public int? NRODOC { get; set; } = 0;
        public string? NOMCOM { get; set; } = null!;
        public DateTime FEULVI { get; set; }
        public string? TIPVIS { get; set; } = null!;
        public string? TIPACO { get; set; } = null!;
        public string? VISACO { get; set; } = null!;
        public string? FOFACA { get; set; } = null!;
        public float? CUBVIX { get; set; } = 0;
        public float? CUBVIY { get; set; } = 0;
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int id { get; set; }
        public Point? IDEASG { get; set; } = null!;
    }
}