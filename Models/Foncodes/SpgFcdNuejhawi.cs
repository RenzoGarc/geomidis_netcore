using NetTopologySuite.Geometries;
using NetTopologySuite;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace GeomidisSystem.Models.Foncodes
{
    [Table("spg_fcd_nuejhawi", Schema = "espaciales")]
    public class SpgFcdNuejhawi
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int CODOBJ { get; set; }
        public string FECREA { get; set; } = null!;
        public string FEMODIF { get; set; } = null!;
        public string FELIMIN { get; set; } = null!;
        public string? CONUEJ { get; set; } = null!;
        public string? NONUEJ { get; set; } = null!;
        public string? PRNUEJ { get; set; } = null!;
        public string? PROPRO { get; set; } = null!;
        public DateTime FIPRPR { get; set; }
        public DateTime FTPRPR { get; set; }
        public int? CANUSU { get; set; } = 0;
        public string? NUEJCE { get; set; } = null!;
        public string? DIRNUC { get; set; } = null!;
        public string? UBIGEO { get; set; } = null!;
        public string? COCEPO { get; set; } = null!;
        public int? COUNTE { get; set; } = 0;
        public float? COOUBX { get; set; } = 0;
        public float? COOUBY { get; set; } = 0;
        public Point? IDEASG { get; set; } = null!;
    }
}