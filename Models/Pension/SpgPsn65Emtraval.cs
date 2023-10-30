using NetTopologySuite.Geometries;
using NetTopologySuite;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace GeomidisSystem.Models.Pension
{
    [Table("spg_psn65_emtraval", Schema = "espaciales")]
    public class SpgPsn65Emtraval
    {
        public string? COPUPA { get; set; } = null!;
        public string? NOPUPA { get; set; } = null!;
        public string? UBIGEO { get; set; } = null!;
        public string? DEPART { get; set; } = null!;
        public string? PROVIN { get; set; } = null!;
        public string? DISTRI { get; set; } = null!;
        public int? CAUSCO { get; set; } = 0;
        public string? ESTETV { get; set; } = null!;
        public float? COUBIX { get; set; } = 0;
        public float? COUBIY { get; set; } = 0;
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int id { get; set; }
        public Point? IDEASG { get; set; } = null!;
    }
}