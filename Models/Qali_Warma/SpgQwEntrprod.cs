using NetTopologySuite.Geometries;
using NetTopologySuite;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace GeomidisSystem.Models.Qali_Warma
{
    [Table("spg_qw_entrprod", Schema = "espaciales")]
    public class SpgQwEntrprod
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int CODOBJ { get; set; }
        public string? FECREA { get; set; } = null!;
        public string? FEMODIF { get; set; } = null!;
        public string? FELIMIN { get; set; } = null!;
        public string? COENPR { get; set; } = null!;
        public string? CENEDU { get; set; } = null!;
        public string? RESDIR { get; set; } = null!;
        public string? NOMPRO { get; set; } = null!;
        public string? FEHOEN { get; set; } = null!;
        public string? RECEED { get; set; } = null!;
        public int? FOTOEN { get; set; } = 0;
        public string? CAMPAN { get; set; } = null!;
        public string? PROCOM { get; set; } = null!;
        public float? COUBEX { get; set; } = 0;
        public float? COUBEY { get; set; } = 0;
        public Point? IDEASG { get; set; } = null!;
    }
}