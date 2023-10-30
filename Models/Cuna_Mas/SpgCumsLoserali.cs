using NetTopologySuite.Geometries;
using NetTopologySuite;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace GeomidisSystem.Models.Cuna_Mas
{
    [Table("spg_cums_loserali", Schema = "espaciales")]
    public class SpgCumsLoserali
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public string CODLOC { get; set; }
        public string? SERALI { get; set; } = null!;
        public string? COMGES { get; set; } = null!;
        public string? DEPART { get; set; } = null!;
        public string? PROVIN { get; set; } = null!;
        public string? DISTRI { get; set; } = null!;
        public string? CENPOB { get; set; } = null!;
        public string? DIRECC { get; set; } = null!;
        public string? ESTLSA { get; set; } = null!;
        public float? COUBIX { get; set; } = 0;
        public float? COUBIY { get; set; } = 0;
        public int? FOTOLO { get; set; } = 0;
        public Point? IDEASG { get; set; } = null!;
    }
}