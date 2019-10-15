using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using filmeslivecoding.Models;

namespace filmeslivecoding.Pages.Filmes
{
    public class CreateModel : PageModel
    {
        private readonly filmeslivecoding.Models.FilmeContext _context;

        public CreateModel(filmeslivecoding.Models.FilmeContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public Filme Filme { get; set; }

        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Filmes.Add(Filme);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
