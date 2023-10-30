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
        public string CODLOC { get; set; }
        public string? NOMLOC { get; set; } = null!;
        public string? COMGES { get; set; } = null!;
        public int? CAPOPE { get; set; } = 0;
        public int? NNULAS { get; set; } = 0;
        public string? DEPART { get; set; } = null!;
        public string? PROVIN { get; set; } = null!;
        public string? CENPOB { get; set; } = null!;
        public string? DIRECC { get; set; } = null!;
        public string? REFERE { get; set; } = null!;
        public int? CANPOB { get; set; } = 0;
        public float? COUBIX { get; set; } = 0;
        public float? COUBIY { get; set; } = 0;
        public Point? IDEASG { get; set; } = null!;
    }
}