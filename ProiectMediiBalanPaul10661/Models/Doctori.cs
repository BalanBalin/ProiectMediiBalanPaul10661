namespace ProiectMediiBalanPaul10661.Models
{
    public class Doctori
    {
        public int Id { get; set; }

        public string Nume { get; set; } = string.Empty;

        public string Prenume { get; set; } =string.Empty;

        public string Specializare { get; set; } = string.Empty;

        public ICollection<Servicii> Servicii { get; set; } = new List<Servicii>();

        public ICollection<Programare> Programari { get; set; } = new List<Programare>();
    }
}
