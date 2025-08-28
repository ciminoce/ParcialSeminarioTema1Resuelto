using Microsoft.EntityFrameworkCore;
using ParcialSeminarioTema1.Entidades.Entidades;

namespace ParcialSeminarioTema1.Datos
{
    public class BibliotecaDbContext : DbContext
    {
        public BibliotecaDbContext(DbContextOptions options) : base(options)
        {
        }

        protected BibliotecaDbContext()
        {
        }
        public DbSet<Libro> Libros { get; set; }
        public DbSet<Genero> Generos { get; set; }
    }
}
