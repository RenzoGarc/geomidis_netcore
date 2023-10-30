using NetTopologySuite.Geometries;
using NetTopologySuite;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace GeomidisSystem.Models.Foncodes
{
    [Table("spg_fcd_cobhawi", Schema = "espaciales")]
    public class SpgFcdCobhawi
    {
        public int? CANHOG { get; set; } = 0;
        public int? CACEPO { get; set; } = 0;
        public float? COOUBX { get; set; } = 0;
        public float? COOUBY { get; set; } = 0;
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int id { get; set; }
        public Point? IDEASG { get; set; } = null!;
        public string? DIHAWI { get; set; } = null!;
        public string? PRHAWI { get; set; } = null!;
        public string? DEHAWI { get; set; } = null!;
    }
}