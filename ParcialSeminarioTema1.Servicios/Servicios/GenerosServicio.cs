using ParcialSeminarioTema1.Datos.Interfaces;
using ParcialSeminarioTema1.Servicios.DTOs.Genero;
using ParcialSeminarioTema1.Servicios.Interfaces;
using ParcialSeminarioTema1.Servicios.Mapeadores;

namespace ParcialSeminarioTema1.Servicios.Servicios
{
    public class GenerosServicio : IGenerosServicio
    {
        private readonly IGenerosRepositorio _generosRepositorio;

        public GenerosServicio(IGenerosRepositorio generosRepositorio)
        {
            _generosRepositorio = generosRepositorio;
        }

        public GeneroListDto? ObtenerGeneroPorNombre(string nombre)
        {
            var genero = _generosRepositorio.ObtenerGeneroPorNombre(nombre);
            if (genero is null) return null;
            return GeneroMapeador.MapearListDto(genero);
        }

        public List<GeneroListDto> ObtenerLista()
        {
            var generos = _generosRepositorio.ObtenerLista();
            return GeneroMapeador.MapearLista(generos);
        }
    }
}
