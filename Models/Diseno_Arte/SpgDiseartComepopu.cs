using NetTopologySuite.Geometries;
using NetTopologySuite;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace GeomidisSystem.Models.Diseno_Arte
{
    [Table("spg_diseart_comepopu", Schema = "espaciales")]
    public class SpgDiseartComepopu
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int CODOBJ { get; set; }
        public string FECREA { get; set; } = null!;
        public string FEMODIF { get; set; } = null!;
        public string FELIMIN { get; set; } = null!;
        public string? CODCOM { get; set; } = null!;
        public string? NOMLOC { get; set; } = null!;
        public string? DIRCOM { get; set; } = null!;
        public string? UBIGEO { get; set; } = null!;
        public string? COCEPO { get; set; } = null!;
        public int? CANBEN { get; set; } = 0;
        public string? ESTCOM { get; set; } = null!;
        public string? RRCEAT { get; set; } = null!;
        public float? COUBIX { get; set; } = 0;
        public float? COUBIY { get; set; } = 0;
        public Point? IDEASG { get; set; } = null!;
    }
}