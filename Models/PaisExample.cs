using System.ComponentModel.DataAnnotations;

namespace GeomidisSystem.Models
{
    public class PaisExample
    {
        [Key]
        public int Id { get; set; }
        public string CANBEN { get; set; } = null!;
        public string CANBEN2 { get; set; } = null!;
        public string CANBEN3 { get; set; } = null!;
        public string CANBEN4 { get; set; } = null!;
        public string CANBEN5 { get; set; } = null!;
        public DateTime Date { get; set; }

    }
}
