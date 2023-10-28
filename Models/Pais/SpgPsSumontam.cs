using NetTopologySuite.Geometries;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GeomidisSystem.Models.Pais
{
    [Table("spg_ps_sumontam", Schema = "espaciales")]
    public class SpgPsSumontam
    {
        public string? NOMTAM { get; set; } = null!;
        public string? SUPERV { get; set; } = null!;
        public string? UNICAR { get; set; } = null!;
        public string ULFEMO { get; set; } = null!;
        public string? PRSUMO { get; set; } = null!;
        public float? COUBIX { get; set; } = 0;
        public float? COUBIY { get; set; } = 0;
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int id { get; set; }
        public Point? IDEASG { get; set; } = null!;
    }
}
