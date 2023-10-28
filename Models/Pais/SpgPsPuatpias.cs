using NetTopologySuite.Geometries;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GeomidisSystem.Models.Pais
{
    [Table("spg_ps_puatpias", Schema = "espaciales")]
    public class SpgPsPuatpias
    {
        public string? NPATCA { get; set; } = null!;
        public int? NUMUSU { get; set; } = 0;
        public int? NUMATE { get; set; } = 0;
        public string? DEPART { get; set; } = null!;
        public string? PROVIN { get; set; } = null!;
        public string? DISTRI { get; set; } = null!;
        public string? CENPOB { get; set; } = null!;
        public string? CUENCA { get; set; } = null!;
        public string? NOMEMB { get; set; } = null!;
        public int? ANOCAM { get; set; } = 0;
        public string? TIPPLA { get; set; } = null!;
        public float? COUBIX { get; set; } = 0;
        public float? COUBIY { get; set; } = 0;
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int id { get; set; }
        public Point? IDEASG { get; set; } = null!;
    }
}
