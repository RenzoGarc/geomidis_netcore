using NetTopologySuite.Geometries;
using NetTopologySuite;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace GeomidisSystem.Models.Pension
{
    [Table("spg_psn65_usupen65", Schema = "espaciales")]
    public class SpgPsn65Usupen65
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int CODOBJ { get; set; }
        public string? FECREA { get; set; } = null!;
        public string? FEMODIF { get; set; } = null!;
        public string? FELIMIN { get; set; } = null!;
        public string? CODUSU { get; set; } = null!;
        public int? TIPDOC { get; set; } = 0;
        public string? NUMDOC { get; set; } = null!;
        public string? NOMCOM { get; set; } = null!;
        public string? DIRUSU { get; set; } = null!;
        public string? COCCPP { get; set; } = null!;
        public string? UBIGEO { get; set; } = null!;
        public string? FEULVI { get; set; } = null!;
        public string? CONVIS { get; set; } = null!;
        public string? TIPUSU { get; set; } = null!;
        public string? COPUPA { get; set; } = null!;
        public string? TIPPAG { get; set; } = null!;
        public float? COUBIX { get; set; } = 0;
        public float? COUBIY { get; set; } = 0;
        public Point? IDEASG { get; set; } = null!;
    }
}