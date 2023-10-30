using NetTopologySuite.Geometries;
using NetTopologySuite;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace GeomidisSystem.Models.Qali_Warma
{
    [Table("spg_qw_supeiiee", Schema = "espaciales")]
    public class SpgQwSupeiiee
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public string CODSUP { get; set; }
        public string? CENEDU { get; set; } = null!;
        public string? RESDIR { get; set; } = null!;
        public string? PROVEE { get; set; } = null!;
        public DateTime FEHOVI { get; set; }
        public int? FOTOSU { get; set; } = 0;
        public string? CAMPAN { get; set; } = null!;
        public string? PROCOM { get; set; } = null!;
        public float? COUBIX { get; set; } = 0;
        public float? COUBIY { get; set; } = 0;
        public string? MOGELO { get; set; } = null!;
        public Point? IDEASG { get; set; } = null!;
    }
}