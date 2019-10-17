using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using filmeslivecoding.Models;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace filmeslivecoding.Pages.Filmes
{
    public class IndexModel : PageModel
    {
        private readonly filmeslivecoding.Models.FilmeContext _context;

        public IndexModel(filmeslivecoding.Models.FilmeContext context)
        {
            _context = context;
        }

        public SelectList Generos;
        
        public IList<Filme> Filme { get;set; }

        public string FilmePorGenero { get; set; }

        public async Task OnGetAsync(string buscaPorGeneroNome, string filmePorGenero)
        {
          #region Lógica inerente a busca de filme por Gênero

          IQueryable<string> queryGenero = from f in _context.Filmes
                                            orderby f.Genero
                                            select f.Genero;

          var filmes = from f in _context.Filmes
                        select f; // ==> select * from Filmes
          
          if(!String.IsNullOrEmpty(buscaPorGeneroNome))
          {
            filmes = filmes.Where(b => b.Titulo.Contains(buscaPorGeneroNome));
          }

          if (!String.IsNullOrEmpty(filmePorGenero))
          {
            filmes = filmes.Where(b => b.Genero == filmePorGenero);
          }
          #endregion

          Generos = new SelectList(await queryGenero.Distinct().ToListAsync());
          Filme = await filmes.ToListAsync();
        }
    }
}
