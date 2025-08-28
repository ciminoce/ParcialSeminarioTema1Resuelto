using ParcialSeminarioTema1.Entidades.Entidades;
using ParcialSeminarioTema1.Servicios.DTOs.Genero;

namespace ParcialSeminarioTema1.Servicios.Mapeadores
{
    public static class GeneroMapeador
    {
        public static GeneroListDto MapearListDto(Genero genero)
        {
            return new GeneroListDto
            {
                GeneroId = genero.GeneroId,
                NombreGenero = genero.NombreGenero,
            };
        }

        public static List<GeneroListDto> MapearLista(List<Genero> generos)
        {
            return generos.Select(MapearListDto).ToList();
        }
    }
}
