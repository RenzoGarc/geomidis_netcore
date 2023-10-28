using NetTopologySuite.Geometries;
using NetTopologySuite;
using System.ComponentModel.DataAnnotations;

namespace GeomidisSystem.Models
{
    public class SpgPsGeometry
    {
        [Key]
        public string CODTAM { get; set; }
        public string? NOMTAM { get; set; } = null!;
        public string? UBIGEO { get; set; } = null!;
        public Geometry? IDEASG { get; set; } = null!;
        //public float[][]? COORDENADAS { get; set; } = null!;
    }
}
