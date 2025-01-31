using System;

namespace ProiectMediiBalanPaul10661.Models
{
    public class Programare
    {
        public int Id { get; set; } // Primary Key

        public string Pacient { get; set; } // Store Patient Name as a String

        public string Doctor { get; set; } // Store Doctor Name as a String

        public string Serviciu { get; set; } // Store Service Name as a String

        public DateTime DataProgramare { get; set; } // Date of Appointment
    }
}
