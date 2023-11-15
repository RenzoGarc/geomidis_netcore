using NetTopologySuite.Geometries;
using NetTopologySuite;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace GeomidisSystem.Models.Juntos
{
    [Table("spg_jts_uniterju", Schema = "espaciales")]
    public class SpgJtsUniterjuObtener
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int CODOBJ { get; set; }
        public string? FECREA { get; set; } = null!;
        public string? FEMODIF { get; set; } = null!;
        public string? FELIMIN { get; set; } = null!;
        public string? COUNTE { get; set; } = null!;
        public string? NOMUT { get; set; } = null!;
        public string? NUMIOB { get; set; } = null!;
        public string? NUHOAB { get; set; } = null!;
        public Geometry? GEOM { get; set; } = null!;
        public float[][]? COORDENADAS { get; set; } = null!;
    }
}