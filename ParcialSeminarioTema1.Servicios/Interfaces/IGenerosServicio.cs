using ParcialSeminarioTema1.Servicios.DTOs.Genero;

namespace ParcialSeminarioTema1.Servicios.Interfaces
{
    public interface IGenerosServicio
    {
        List<GeneroListDto> ObtenerLista();
        GeneroListDto? ObtenerGeneroPorNombre(string nombre);
    }
}
