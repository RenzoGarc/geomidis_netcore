using NetTopologySuite.Geometries;
using NetTopologySuite;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GeomidisSystem.Models.Contigo
{
    [Table("spg_ctg_usprocon", Schema = "espaciales")]
    public class SpgCtgUsprocon
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int CODOBJ { get; set; }
        public int? TIPDOC { get; set; } = 0;
        public string? NUMDOC { get; set; } = null!;
        public string? APEPAT { get; set; } = null!;
        public string? APEMAT { get; set; } = null!;
        public string? NOMBRE { get; set; } = null!;
        public int? EDADPR { get; set; } = 0;
        public string? CONEDA { get; set; } = null!;
        public string? ESTUSU { get; set; } = null!;
        public string? UBIGEO { get; set; } = null!;
        public string? APPAAU { get; set; } = null!;
        public string? APMAAU { get; set; } = null!;
        public string? NOMAUT { get; set; } = null!;
        public string? FECAFI { get; set; } = null!;
        public string? REDICO { get; set; } = null!;
        public float? CUBVIX { get; set; } = 0;
        public float? CUBVIY { get; set; } = 0;
        public Point? IDEASG { get; set; } = null!;
        public string FECREA { get; set; } = null!;
        public string FEMODIF { get; set; } = null!;
        public string FELIMIN { get; set; } = null!;
    }
}