using NetTopologySuite.Geometries;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GeomidisSystem.Models.Pais
{
    [Table("spg_ps_unidterr", Schema = "espaciales")]
    public class SpgPsUnidterr
    {
        [Key]
        public string COUNTE { get; set; }
        public string NOUNTE { get; set; } = null!;
        public string DEPART { get; set; } = null!;
        public string PROVIN { get; set; } = null!;
        public string DISTRI { get; set; } = null!;
        public string DIRECC { get; set; } = null!;
        public string JEUNTE { get; set; } = null!;
        public int? CANTAM { get; set; } = 0;
        public float? COUBIX { get; set; } = 0;
        public float? COUBIY { get; set; } = 0;
        public Point? IDEASG { get; set; } = null!;
    }
}
