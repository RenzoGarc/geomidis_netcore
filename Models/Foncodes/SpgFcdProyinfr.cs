using NetTopologySuite.Geometries;
using NetTopologySuite;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace GeomidisSystem.Models.Foncodes
{
    [Table("spg_fcd_proyinfr", Schema = "espaciales")]
    public class SpgFcdProyinfr
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int CODOBJ { get; set; }
        public string? FECREA { get; set; } = null!;
        public string? FEMODIF { get; set; } = null!;
        public string? FELIMIN { get; set; } = null!;
        public int? NUMCON { get; set; } = 0;
        public string? NOMPRO { get; set; } = null!;
        public string? UBIGEO { get; set; } = null!;
        public string? COCEPO { get; set; } = null!;
        public string? CENPOB { get; set; } = null!;
        public float? MONINV { get; set; } = 0;
        public string? ESTADO { get; set; } = null!;
        public string? FECINI { get; set; } = null!;
        public string? FECTER { get; set; } = null!;
        public string? LININT { get; set; } = null!;
        public string? COUNTE { get; set; } = null!;
        public float? COOUBX { get; set; } = 0;
        public float? COOUBY { get; set; } = 0;
        public Point? IDEASG { get; set; } = null!;
    }
}