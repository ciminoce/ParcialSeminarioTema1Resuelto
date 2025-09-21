using ParcialSeminarioTema1.Entidades.Entidades;

namespace ParcialSeminarioTema1.Datos.Interfaces
{
    public interface ILibrosRepositorio
    {
        List<Libro> ObtenerLista(int? generoId=null);
        int ObtenerCantidad(int? generoId=null);

        void Agregar(Libro libro);
        bool ExisteLibro(Libro libro);
        Libro? ObtenerPorId(int libroId);
        void Eliminar(int libroId);
    }
}
