using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using ProiectMediiBalanPaul10661.Data;
using ProiectMediiBalanPaul10661.Models;

namespace ProiectMediiBalanPaul10661.Pages.Doctor
{
    public class EditModel : PageModel
    {
        private readonly ProiectMediiBalanPaul10661.Data.ClinicContext _context;

        public EditModel(ProiectMediiBalanPaul10661.Data.ClinicContext context)
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

            var doctori =  await _context.Doctori.FirstOrDefaultAsync(m => m.Id == id);
            if (doctori == null)
            {
                return NotFound();
            }
            Doctori = doctori;
            return Page();
        }

        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more information, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Attach(Doctori).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!DoctoriExists(Doctori.Id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return RedirectToPage("./Index");
        }

        private bool DoctoriExists(int id)
        {
            return _context.Doctori.Any(e => e.Id == id);
        }
    }
}
