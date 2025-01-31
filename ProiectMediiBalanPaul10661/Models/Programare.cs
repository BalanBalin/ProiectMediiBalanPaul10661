using System;

namespace ProiectMediiBalanPaul10661.Models
{
    public class Programare
    {
        public int Id { get; set; }

        public string Pacient { get; set; }

        public string Doctor { get; set; }

        public string Serviciu { get; set; }

        public DateTime DataProgramare { get; set; }
    }
}
