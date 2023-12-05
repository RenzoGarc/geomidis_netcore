using NetTopologySuite.Geometries;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GeomidisSystem.Models.Pais
{
    [Table("spg_ps_unidterr", Schema = "espaciales")]
    public class SpgPsUnidterr
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int CODOBJ { get; set; }
        public string FECREA { get; set; } = null!;
        public string FEMODIF { get; set; } = null!;
        public string FELIMIN { get; set; } = null!;
        public string COUNTE { get; set; } = null!;
        public string NOUNTE { get; set; } = null!;
        public string? UBIGEO { get; set; } = null!;
        public string DIRECC { get; set; } = null!;
        public string JEUNTE { get; set; } = null!;
        public int? CANTAM { get; set; } = 0;
        public float? COUBIX { get; set; } = 0;
        public float? COUBIY { get; set; } = 0;
        public Point? IDEASG { get; set; } = null!;
    }
}
