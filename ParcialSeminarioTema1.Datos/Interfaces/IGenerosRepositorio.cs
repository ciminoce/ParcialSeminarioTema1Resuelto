using ParcialSeminarioTema1.Entidades.Entidades;

namespace ParcialSeminarioTema1.Datos.Interfaces
{
    public interface IGenerosRepositorio
    {
        List<Genero> ObtenerLista();
        Genero? ObtenerGeneroPorNombre(string nombre);
    }
}
