using Microsoft.EntityFrameworkCore;
using ProiectMediiBalanPaul10661.Models;

namespace ProiectMediiBalanPaul10661.Data
{
    public class ClinicContext : DbContext
    {
        public ClinicContext(DbContextOptions<ClinicContext> options) : base(options) { }

        public DbSet<Pacient> Pacienti { get; set; }
        public DbSet<Doctori> Doctori { get; set; }
        public DbSet<Servicii> Servicii { get; set; }
        public DbSet<Programare> Programari { get; set; }
    }
}
