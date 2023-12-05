using NetTopologySuite.Geometries;
using NetTopologySuite;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace GeomidisSystem.Models.Cuna_Mas
{
    [Table("spg_cums_frseacfa", Schema = "espaciales")]
    public class SpgCumsFrseacfa
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int CODOBJ { get; set; }
        public string? FECREA { get; set; } = null!;
        public string? FEMODIF { get; set; } = null!;
        public string? FELIMIN { get; set; } = null!;
        public string? CODFAM { get; set; } = null!;
        public string? UNITER { get; set; } = null!;
        public string? COMGES { get; set; } = null!;
        public int? CANVIS { get; set; } = 0;
        public int? CANUSU { get; set; } = 0;
        public int? CANNIO { get; set; } = 0;
        public int? CANNIA { get; set; } = 0;
        public int? CANGES { get; set; } = 0;
        public string? UBIGEO { get; set; } = null!;
        public string? COCEPO { get; set; } = null!;
        public string? CENPOB { get; set; } = null!;
        public string? DIRECC { get; set; } = null!;
        public string? REFERE { get; set; } = null!;
        public float? COUBIX { get; set; } = 0;
        public float? COUBIY { get; set; } = 0;
        public Point? IDEASG { get; set; } = null!;
        
    }
}