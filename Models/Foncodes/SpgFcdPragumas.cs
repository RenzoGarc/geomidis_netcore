using NetTopologySuite.Geometries;
using NetTopologySuite;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace GeomidisSystem.Models.Foncodes
{
    [Table("spg_fcd_pragumas", Schema = "espaciales")]
    public class SpgFcdPragumas
    {
        public string? EXPEDI { get; set; } = null!;
        public string? UBICAC { get; set; } = null!;
        public string? NOMPRO { get; set; } = null!;
        public int? CANBEN { get; set; } = 0;
        public float? MONTOS { get; set; } = 0;
        public DateTime FECINI { get; set; }
        public DateTime FECTER { get; set; }
        public string? ESTINT { get; set; } = null!;
        public int? COUNTE { get; set; } = 0;
        public float? COOUBX { get; set; } = 0;
        public float? COOUBY { get; set; } = 0;
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int id { get; set; }
        public Point? IDEASG { get; set; } = null!;
    }
}