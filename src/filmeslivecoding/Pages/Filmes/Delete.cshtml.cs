using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using filmeslivecoding.Models;

namespace filmeslivecoding.Pages.Filmes
{
    public class DeleteModel : PageModel
    {
        private readonly filmeslivecoding.Models.FilmeContext _context;

        public DeleteModel(filmeslivecoding.Models.FilmeContext context)
        {
            _context = context;
        }

        [BindProperty]
        public Filme Filme { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Filme = await _context.Filmes.FirstOrDefaultAsync(m => m.FilmeId == id);

            if (Filme == null)
            {
                return NotFound();
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Filme = await _context.Filmes.FindAsync(id);

            if (Filme != null)
            {
                _context.Filmes.Remove(Filme);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
