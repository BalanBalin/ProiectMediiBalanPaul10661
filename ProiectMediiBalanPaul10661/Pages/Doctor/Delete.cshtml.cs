using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using ProiectMediiBalanPaul10661.Data;
using ProiectMediiBalanPaul10661.Models;

namespace ProiectMediiBalanPaul10661.Pages.Doctor
{
    public class DeleteModel : PageModel
    {
        private readonly ProiectMediiBalanPaul10661.Data.ClinicContext _context;

        public DeleteModel(ProiectMediiBalanPaul10661.Data.ClinicContext context)
        {
            _context = context;
        }

        [BindProperty]
        public Doctori Doctori { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var doctori = await _context.Doctori.FirstOrDefaultAsync(m => m.Id == id);

            if (doctori == null)
            {
                return NotFound();
            }
            else
            {
                Doctori = doctori;
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var doctori = await _context.Doctori.FindAsync(id);
            if (doctori != null)
            {
                Doctori = doctori;
                _context.Doctori.Remove(Doctori);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
