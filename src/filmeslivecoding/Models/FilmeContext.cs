using Microsoft.EntityFrameworkCore;

namespace filmeslivecoding.Models 
{
    public class FilmeContext : DbContext 
    {
      public FilmeContext(DbContextOptions<FilmeContext> options)
        :base(options)
        {
          // Classe Default
        }

        public DbSet<Filme> Filmes { get; set; }
    }
}