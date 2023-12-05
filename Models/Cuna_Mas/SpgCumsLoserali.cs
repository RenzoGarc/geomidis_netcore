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
        public int CODOBJ { get; set; }
        public string? FECREA { get; set; } = null!;
        public string? FEMODIF { get; set; } = null!;
        public string? FELIMIN { get; set; } = null!;
        public string? CODLOC { get; set; } = null!;
        public string? SERALI { get; set; } = null!;
        public string? COMGES { get; set; } = null!;
        public string? COUNTE { get; set; } = null!;
        public string? UBIGEO { get; set; } = null!;
        public string? COCEPO { get; set; } = null!;
        public string? CENPOB { get; set; } = null!;
        public string? DIRECC { get; set; } = null!;
        public string? REFERE { get; set; } = null!;
        public string? ESTLSA { get; set; } = null!;
        public float? COUBIX { get; set; } = 0;
        public float? COUBIY { get; set; } = 0;
        public string? FOTOLO { get; set; } = null!;
        public Point? IDEASG { get; set; } = null!;
    }
}