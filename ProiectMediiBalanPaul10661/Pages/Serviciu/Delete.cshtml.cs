using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using ProiectMediiBalanPaul10661.Data;
using ProiectMediiBalanPaul10661.Models;

namespace ProiectMediiBalanPaul10661.Pages.Serviciu
{
    public class DeleteModel : PageModel
    {
        private readonly ProiectMediiBalanPaul10661.Data.ClinicContext _context;

        public DeleteModel(ProiectMediiBalanPaul10661.Data.ClinicContext context)
        {
            _context = context;
        }

        [BindProperty]
        public Servicii Servicii { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var servicii = await _context.Servicii.FirstOrDefaultAsync(m => m.Id == id);

            if (servicii == null)
            {
                return NotFound();
            }
            else
            {
                Servicii = servicii;
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var servicii = await _context.Servicii.FindAsync(id);
            if (servicii != null)
            {
                Servicii = servicii;
                _context.Servicii.Remove(Servicii);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
