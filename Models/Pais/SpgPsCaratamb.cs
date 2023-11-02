using NetTopologySuite.Geometries;
using NetTopologySuite;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GeomidisSystem.Models.Pais
{
    [Table("spg_ps_caratamb", Schema = "espaciales")]
    public class SpgPsCaratamb
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int CODOBJ { get; set; }
        public string CODTAM { get; set; } = null!;
        public string? NOMTAM { get; set; } = null!;
        public string? UBIGEO { get; set; } = null!;
        public float? COCEPO { get; set; } = 0;
        public int? ALTITU { get; set; } = 0;
        public int? CANPOB { get; set; } = 0;
        public int? CANVIV { get; set; } = 0;
        public int? HOGARE { get; set; } = 0;
        public int? POBOBJ { get; set; } = 0;
        public int? NCPAIN { get; set; } = 0;
        public string? ZOPOTE { get; set; } = null!;
        public string? IMPEST { get; set; } = null!;
        public string? CUENCA { get; set; } = null!;
        public int? AREA { get; set; } = 0;
        public int? PERIME { get; set; } = 0;
        public string? ESTADO { get; set; } = null!;
        public string? SNIPTA { get; set; } = null!;
        public string? EJETEM { get; set; } = null!;
        public string? TIPINT { get; set; } = null!;
        public int? NUMINT { get; set; } = 0;
        public int? NUMATE { get; set; } = 0;
        public int? NUMUSU { get; set; } = 0;
        public string? COUNTE { get; set; } = null!;
        public string FECREA { get; set; } = null!;
        public string FEMODIF { get; set; } = null!;
        public string FELIMIN { get; set; } = null!;
        public float? COUBIX { get; set; } = 0;
        public float? COUBIY { get; set; } = 0;
        public Point? IDEASG { get; set; } = null!;
    }
}
