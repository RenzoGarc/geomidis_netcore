using NetTopologySuite.Geometries;
using NetTopologySuite;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace GeomidisSystem.Models.Cuna_Mas
{
    [Table("spg_cums_distfoca", Schema = "espaciales")]
    public class SpgCumsDistfoca
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public string CODIFO { get; set; }
        public string? NRREMI { get; set; } = null!;
        public DateTime FECAPR { get; set; }
        public string? INFOAN { get; set; } = null!;
        public string? SERSAF { get; set; } = null!;
        public string? SERSCD { get; set; } = null!;
        public int? POBSAF { get; set; } = 0;
        public int? POBSCD { get; set; } = 0;
        public int? CANFAM { get; set; } = 0;
        public int? CANUSU { get; set; } = 0;
        public int? CANLOC { get; set; } = 0;
        public float? COUBIX { get; set; } = 0;
        public float? COUBIY { get; set; } = 0;
        public string? INTERV { get; set; } = null!;
        public Point? IDEASG { get; set; } = null!;
    }
}