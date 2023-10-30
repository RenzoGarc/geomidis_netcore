using NetTopologySuite.Geometries;
using NetTopologySuite;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace GeomidisSystem.Models.Focalizacion
{
    [Table("spg_fcl_hogdgfis", Schema = "espaciales")]
    public class SpgFclHogdgfis
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public string CODHOG { get; set; }
        public string? UBIGEO { get; set; } = null!;
        public string? DEPART { get; set; } = null!;
        public string? PROVIN { get; set; } = null!;
        public string? DISTRI { get; set; } = null!;
        public string? COCEPO { get; set; } = null!;
        public string? VECEPO { get; set; } = null!;
        public string? IDHOGA { get; set; } = null!;
        public string? DIRECC { get; set; } = null!;
        public string? REFERE { get; set; } = null!;
        public float? COORX { get; set; } = 0;
        public float? COORY { get; set; } = 0;
        public int? METCAP { get; set; } = 0;
        public int? ESTHOG { get; set; } = 0;
        public Point? IDEASG { get; set; } = null!;
    }
}