using NetTopologySuite.Geometries;
using NetTopologySuite;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace GeomidisSystem.Models.Foncodes
{
    [Table("spg_fcd_proyinfr", Schema = "espaciales")]
    public class SpgFcdProyinfr
    {
        public int? NUMCON { get; set; } = 0;
        public string? NOMPRO { get; set; } = null!;
        public string? UBIPRO { get; set; } = null!;
        public string? UBIGEO { get; set; } = null!;
        public float? MONINV { get; set; } = 0;
        public string? ESTADO { get; set; } = null!;
        public DateTime FECINI { get; set; }
        public DateTime FECTER { get; set; }
        public string? LININT { get; set; } = null!;
        public string? COUNTE { get; set; } = null!;
        public float? COOUBX { get; set; } = 0;
        public float? COOUBY { get; set; } = 0;
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int id { get; set; }
        public Point? IDEASG { get; set; } = null!;
    }
}