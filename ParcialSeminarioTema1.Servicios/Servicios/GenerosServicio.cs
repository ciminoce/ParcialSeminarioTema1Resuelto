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

        public (bool Exito, string Mensaje) Eliminar(string nombre)
        {
            var genero=_generosRepositorio.ObtenerGeneroPorNombre(nombre);
            if(genero is null)
            {
                return (false, "Género no encontrado");
            }
            try
            {
                if (!_generosRepositorio.EstaRelacionado(genero.GeneroId))
                {
                    _generosRepositorio.Eliminar(genero.GeneroId);
                    return (true, "Género eliminado satisfactoriamente!!!");

                }
                else
                {
                    return (false, "Género relacionado\n" + "Baja denegada!!!");
                }

            }
            catch (Exception ex)
            {

                return (false, "Joder algo salió mal\n" + ex.Message);
            }
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
