using ParcialSeminarioTema1.Datos.Interfaces;
using ParcialSeminarioTema1.Entidades.Entidades;
using ParcialSeminarioTema1.Servicios.DTOs.Libro;
using ParcialSeminarioTema1.Servicios.Interfaces;
using ParcialSeminarioTema1.Servicios.Mapeadores;

namespace ParcialSeminarioTema1.Servicios.Servicios
{
    public class LibrosServicio : ILibrosServicio
    {
        private readonly ILibrosRepositorio _librosRepositorio;

        public LibrosServicio(ILibrosRepositorio librosRepositorio)
        {
            _librosRepositorio = librosRepositorio;
        }

        public LibroListDto? Guardar(LibroEditDto libroDto, out List<string> errores)
        {
            errores = new List<string>();
            Libro libro = LibrosMapeador.MapearEntidad(libroDto);
            if (_librosRepositorio.ExisteLibro(libro))
            {
                errores.Add("Libro existente");
                return null;
            }
            if (libro.LibroId == 0)
            {
                _librosRepositorio.Agregar(libro);
            }
            /*
             * Una vez guardardo el libro
             * lo accedo por su Id para poder obtener todos 
             * sus datos y luego poder mapear al DTo
             */
            var nuevoLibro = _librosRepositorio.ObtenerPorId(libro.LibroId);
            return LibrosMapeador.MapearListDto(nuevoLibro!);
            
        }

        public int ObtenerCantidad(int? generoId = null)
        {
            return _librosRepositorio.ObtenerCantidad(generoId);
        }

        public List<LibroListDto> ObtenerLista(int? generoId = null)
        {
            var libros = _librosRepositorio.ObtenerLista(generoId);
            return LibrosMapeador.MapearLista(libros);
        }
    }
}
