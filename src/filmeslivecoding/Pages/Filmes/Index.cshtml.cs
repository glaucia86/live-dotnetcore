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
    public class IndexModel : PageModel
    {
        private readonly filmeslivecoding.Models.FilmeContext _context;

        public IndexModel(filmeslivecoding.Models.FilmeContext context)
        {
            _context = context;
        }

        public IList<Filme> Filme { get;set; }

        public async Task OnGetAsync()
        {
            Filme = await _context.Filmes.ToListAsync();
        }
    }
}
