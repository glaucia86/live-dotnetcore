using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
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

        [BindProperty(SupportsGet = true)]
        public string BuscaPorFilme { get; set; }

        public SelectList Generos { get; set; }
        
        [BindProperty(SupportsGet = true)]
        public string FilmePorGenero { get; set; }

        public async Task OnGetAsync()
        {
          var filmes = from f in _context.Filmes
                        select f;
          
          if (!string.IsNullOrEmpty(BuscaPorFilme))
          {
            filmes = filmes.Where(b => b.Titulo.Contains(BuscaPorFilme));
          }

          Filme = await filmes.ToListAsync();
        }
    }
}
