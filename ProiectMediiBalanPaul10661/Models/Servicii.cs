using System.ComponentModel.DataAnnotations.Schema;

namespace ProiectMediiBalanPaul10661.Models
{
    public class Servicii
    {
        public int Id { get; set; }

        public string Nume { get; set; } = string.Empty;

        [Column(TypeName = "decimal(18,2)")]
        public decimal Pret { get; set; }

        public string Specializare { get; set; } = string.Empty;
    }
}
