using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using ProiectMediiBalanPaul10661.Data;
using ProiectMediiBalanPaul10661.Models;

namespace ProiectMediiBalanPaul10661.Pages.Pacienti
{
    public class DeleteModel : PageModel
    {
        private readonly ProiectMediiBalanPaul10661.Data.ClinicContext _context;

        public DeleteModel(ProiectMediiBalanPaul10661.Data.ClinicContext context)
        {
            _context = context;
        }

        [BindProperty]
        public Pacient Pacient { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var pacient = await _context.Pacienti.FirstOrDefaultAsync(m => m.Id == id);

            if (pacient == null)
            {
                return NotFound();
            }
            else
            {
                Pacient = pacient;
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var pacient = await _context.Pacienti.FindAsync(id);
            if (pacient != null)
            {
                Pacient = pacient;
                _context.Pacienti.Remove(Pacient);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
