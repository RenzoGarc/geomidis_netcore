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
        public int CODOBJ { get; set; }
        public string FECREA { get; set; } = null!;
        public string FEMODIF { get; set; } = null!;
        public string FELIMIN { get; set; } = null!;
        public string? COCEPO { get; set; } = null!;
        public string? UBIGEO { get; set; } = null!;
        public float? COUBIX { get; set; } = 0;
        public float? COUBIY { get; set; } = 0;
        public string? AMAZON { get; set; } = null!;
        public string? ARURRU { get; set; } = null!;
        public string? VERSIO { get; set; } = null!;
        public int? ESTCPO { get; set; } = 0;
        public Point? IDEASG { get; set; } = null!;
    }
}