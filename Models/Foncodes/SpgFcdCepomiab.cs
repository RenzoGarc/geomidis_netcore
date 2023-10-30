using NetTopologySuite.Geometries;
using NetTopologySuite;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace GeomidisSystem.Models.Foncodes
{
    [Table("spg_fcd_cepomiab", Schema = "espaciales")]
    public class SpgFcdCepomiab
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public string COCEPO { get; set; }
        public string? NOCEPO { get; set; } = null!;
        public string? DECEPO { get; set; } = null!;
        public string? PRCEPO { get; set; } = null!;
        public string? DICEPO { get; set; } = null!;
        public float? COOUBX { get; set; } = 0;
        public float? COOUBY { get; set; } = 0;
        public Point? IDEASG { get; set; } = null!;
    }
}