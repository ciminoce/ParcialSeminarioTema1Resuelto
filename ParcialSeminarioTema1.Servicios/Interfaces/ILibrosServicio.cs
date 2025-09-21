using ParcialSeminarioTema1.Servicios.DTOs.Libro;

namespace ParcialSeminarioTema1.Servicios.Interfaces
{
    public interface ILibrosServicio
    {
        List<LibroListDto> ObtenerLista(int? generoId=null);
        int ObtenerCantidad(int? generoId=null);
        LibroListDto? Guardar(LibroEditDto libroDto, out List<string> errores);
        (bool exito, string mensaje) Eliminar(int libroId);
    }
}
