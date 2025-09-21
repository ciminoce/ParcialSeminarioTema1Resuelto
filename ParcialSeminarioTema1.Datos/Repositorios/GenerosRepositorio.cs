using Microsoft.EntityFrameworkCore;
using ParcialSeminarioTema1.Datos.Interfaces;
using ParcialSeminarioTema1.Entidades.Entidades;

namespace ParcialSeminarioTema1.Datos.Repositorios
{
    public class GenerosRepositorio : IGenerosRepositorio
    {
        private readonly BibliotecaDbContext _dbContext;

        public GenerosRepositorio(BibliotecaDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public void Eliminar(int generoId)
        {
            var generoInDb = _dbContext.Generos
                .FirstOrDefault(g => g.GeneroId == generoId);
            if (generoInDb == null)
            {
                throw new Exception("Género no encontrado!!!");
            }
            _dbContext.Generos.Remove(generoInDb);
            _dbContext.SaveChanges();
        }

        public bool EstaRelacionado(int generoId)
        {
            return _dbContext.Libros.Any(l=>l.GeneroId==generoId);
        }

        public Genero? ObtenerGeneroPorNombre(string nombre)
        {
            return _dbContext.Generos
                .FirstOrDefault(g=>g.NombreGenero==nombre);
        }

        public List<Genero> ObtenerLista()
        {
            return _dbContext.Generos
                .AsNoTracking()
                .ToList();
        }
    }
}
