using Microsoft.EntityFrameworkCore;
using ParcialSeminarioTema1.Datos.Interfaces;
using ParcialSeminarioTema1.Entidades.Entidades;

namespace ParcialSeminarioTema1.Datos.Repositorios
{
    public class LibrosRepositorio : ILibrosRepositorio
    {
        private readonly BibliotecaDbContext _dbContext;

        public LibrosRepositorio(BibliotecaDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public void Agregar(Libro libro)
        {
            _dbContext.Libros.Add(libro);
            _dbContext.SaveChanges();
        }

        public bool ExisteLibro(Libro libro)
        {
            return _dbContext.Libros.Any(
                l => l.Titulo == libro.Titulo &&
                l.GeneroId == libro.GeneroId);
        }

        public int ObtenerCantidad(int? generoId = null)
        {
            IQueryable<Libro> query = _dbContext.Libros;
            return generoId == null ? query.Count() 
                : query.Count(l => l.GeneroId == generoId);
        }

        public List<Libro> ObtenerLista(int? generoId = null)
        {
            IQueryable<Libro> query = _dbContext.Libros
                .Include(l => l.Genero).AsNoTracking();

            return generoId == null ? query.ToList()
                : query.Where(l => l.GeneroId == generoId).ToList();
        }

        public Libro? ObtenerPorId(int libroId)
        {
            return _dbContext.Libros
                .Include(l => l.Genero)
                .FirstOrDefault(l => l.LibroId == libroId);
        }
    }
}
