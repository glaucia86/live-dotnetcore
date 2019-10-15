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
    public class DetailsModel : PageModel
    {
        private readonly filmeslivecoding.Models.FilmeContext _context;

        public DetailsModel(filmeslivecoding.Models.FilmeContext context)
        {
            _context = context;
        }

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
    }
}
