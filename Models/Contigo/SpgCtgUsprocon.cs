using NetTopologySuite.Geometries;
using NetTopologySuite;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GeomidisSystem.Models.Contigo
{
    [Table("spg_ctg_usprocon", Schema = "espaciales")]
    public class SpgCtgUsprocon
    {
        public int? TIPDOC { get; set; } = 0;
        public string? NUMDOC { get; set; } = null!;
        public string? APEPAT { get; set; } = null!;
        public string? APEMAT { get; set; } = null!;
        public string? NOMBRE { get; set; } = null!;
        public int? EDADPR { get; set; } = 0;
        public string? CONEDA { get; set; } = null!;
        public string? ESTUSU { get; set; } = null!;
        public int? UBIGEO { get; set; } = 0;
        public string? APPAAU { get; set; } = null!;
        public string? APMAAU { get; set; } = null!;
        public string? NOMAUT { get; set; } = null!;
        public DateTime FECAFI { get; set; }
        public string? REDICO { get; set; } = null!;
        public float? CUBVIX { get; set; } = 0;
        public float? CUBVIY { get; set; } = 0;
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int id { get; set; }
        public Point? IDEASG { get; set; } = null!;
    }
}