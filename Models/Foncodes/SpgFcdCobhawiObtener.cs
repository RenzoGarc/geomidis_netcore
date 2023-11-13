using NetTopologySuite.Geometries;
using NetTopologySuite;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace GeomidisSystem.Models.Foncodes
{
    [Table("spg_fcd_cobhawi", Schema = "espaciales")]
    public class SpgFcdCobhawiObtener
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int CODOBJ { get; set; }
        public string FECREA { get; set; } = null!;
        public string FEMODIF { get; set; } = null!;
        public string FELIMIN { get; set; } = null!;
        public string? UBIGEO { get; set; } = null!;
        public int? CANHOG { get; set; } = 0;
        public int? CACEPO { get; set; } = 0;
        public float? COOUBX { get; set; } = 0;
        public float? COOUBY { get; set; } = 0;
        public Geometry? GEOMTR { get; set; } = null!;
        public float[][]? COORDENADAS { get; set; } = null!;
    }
}