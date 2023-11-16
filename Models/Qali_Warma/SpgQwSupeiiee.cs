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
        public int CODOBJ { get; set; }
        public string? FECREA { get; set; } = null!;
        public string? FEMODIF { get; set; } = null!;
        public string? FELIMIN { get; set; } = null!;
        public string? CODSUP { get; set; } = null!;
        public string? CENEDU { get; set; } = null!;
        public string? RESDIR { get; set; } = null!;
        public string? PROVEE { get; set; } = null!;
        public string? FEHOVI { get; set; } = null!;
        public int? FOTOSU { get; set; } = 0;
        public string? CAMPAN { get; set; } = null!;
        public string? PROCOM { get; set; } = null!;
        public float? COUBIX { get; set; } = 0;
        public float? COUBIY { get; set; } = 0;
        public string? MOGELO { get; set; } = null!;
        public Point? IDEASG { get; set; } = null!;
    }
}