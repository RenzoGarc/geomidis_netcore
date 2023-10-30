using NetTopologySuite.Geometries;
using NetTopologySuite;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace GeomidisSystem.Models.Foncodes
{
    [Table("spg_fcd_cepohawi", Schema = "espaciales")]
    public class SpgFcdCepohawi
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public string COCEPO { get; set; }
        public string? CPHAWI { get; set; } = null!;
        public string? DEHAWI { get; set; } = null!;
        public string? PRHAWI { get; set; } = null!;
        public string? DIHAWI { get; set; } = null!;
        public string? CONCEPO { get; set; } = null!;
        public float? COOUBX { get; set; } = 0;
        public float? COOUBY { get; set; } = 0;
        public Point? IDEASG { get; set; } = null!;
    }
}