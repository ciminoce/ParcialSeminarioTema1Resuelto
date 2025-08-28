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
