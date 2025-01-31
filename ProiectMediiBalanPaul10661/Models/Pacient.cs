using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ProiectMediiBalanPaul10661.Models
{
    public class Pacient
    {
        public int Id { get; set; }

        [Required, StringLength(50)]
        public string Nume { get; set; } = string.Empty;

        [Required, StringLength(50)]
        public string Prenume { get; set; } = string.Empty;

        [Required]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:dd/MM/yyyy}")]
        [Column(TypeName = "date")]
        public DateTime DataNasterii { get; set; }

        [Required, Phone]
        public string Telefon { get; set; } = string.Empty ;

        [Required, EmailAddress]
        public string Email { get; set; } = string.Empty;

        public ICollection<Programare> Programari { get; set; } = new List<Programare>();
    }
}
