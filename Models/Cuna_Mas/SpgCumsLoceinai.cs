using NetTopologySuite.Geometries;
using NetTopologySuite;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace GeomidisSystem.Models.Cuna_Mas
{
    [Table("spg_cums_loceinai", Schema = "espaciales")]
    public class SpgCumsLoceinai
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int CODOBJ { get; set; }
        public string? FECREA { get; set; } = null!;
        public string? FEMODIF { get; set; } = null!;
        public string? FELIMIN { get; set; } = null!; 
        public string? CODLOC { get; set; } = null!;
        public string? NOMLOC { get; set; } = null!;
        public string? ESTLOC { get; set; } = null!;
        public string? COMGES { get; set; } = null!;
        public int? CAPOPE { get; set; } = 0;
        public int? NNULAS { get; set; } = 0;
        public string? UBIGEO { get; set; } = null!;
        public string? COCEPO { get; set; } = null!;
        public string? COUNTE { get; set; } = null!;
        public string? DIRECC { get; set; } = null!;
        public string? REFERE { get; set; } = null!;
        public string? IMAGEN { get; set; } = null!;
        public float? COUBIX { get; set; } = 0;
        public float? COUBIY { get; set; } = 0;
        public Point? IDEASG { get; set; } = null!;
    }
}