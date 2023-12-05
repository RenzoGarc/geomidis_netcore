using NetTopologySuite.Geometries;
using NetTopologySuite;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace GeomidisSystem.Models.Foncodes
{
    [Table("spg_fcd_pragumas", Schema = "espaciales")]
    public class SpgFcdPragumas
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int CODOBJ { get; set; }
        public string? FECREA { get; set; } = null!;
        public string? FEMODIF { get; set; } = null!;
        public string? FELIMIN { get; set; } = null!;
        public string? EXPEDI { get; set; } = null!;
        public string? NOMPRO { get; set; } = null!;
        public int? CANBEN { get; set; } = 0;
        public float? MONTOS { get; set; } = 0;
        public string? FECINI { get; set; } = null!;
        public string? FECTER { get; set; } = null!;
        public string? ESTINT { get; set; } = null!;
        public int? COUNTE { get; set; } = 0;
        public string? UBIGEO { get; set; } = null!;
        public string? COCEPO { get; set; } = null!;
        public string? CENPOB { get; set; } = null!;
        public float? COOUBX { get; set; } = 0;
        public float? COOUBY { get; set; } = 0;
        public Point? IDEASG { get; set; } = null!;
    }
}