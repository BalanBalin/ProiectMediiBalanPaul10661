using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using ProiectMediiBalanPaul10661.Data;
using ProiectMediiBalanPaul10661.Models;

namespace ProiectMediiBalanPaul10661.Pages.Programari
{
    public class CreateModel : PageModel
    {
        private readonly ProiectMediiBalanPaul10661.Data.ClinicContext _context;

        public CreateModel(ProiectMediiBalanPaul10661.Data.ClinicContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public Programare Programare { get; set; } = default!;

        // For more information, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Programari.Add(Programare);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
