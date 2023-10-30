using NetTopologySuite.Geometries;
using NetTopologySuite;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace GeomidisSystem.Models.Focalizacion
{
    [Table("spg_fcl_cpdgfi", Schema = "espaciales")]
    public class SpgFclCpdgfi
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public string COCEPO { get; set; }
        public string? NOMLOC { get; set; } = null!;
        public string? DEPART { get; set; } = null!;
        public string? PROVIN { get; set; } = null!;
        public string? DISTRI { get; set; } = null!;
        public float? COUBIX { get; set; } = 0;
        public float? COUBIY { get; set; } = 0;
        public string? AMAZON { get; set; } = null!;
        public string? ARURRU { get; set; } = null!;
        public string? VERSIO { get; set; } = null!;
        public Point? IDEASG { get; set; } = null!;
    }
}