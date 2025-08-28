using ParcialSeminarioTema1.Entidades.Entidades;
using ParcialSeminarioTema1.Servicios.DTOs.Libro;

namespace ParcialSeminarioTema1.Servicios.Mapeadores
{
    public static class LibrosMapeador
    {
        public static LibroListDto MapearListDto(Libro libro)
        {
            return new LibroListDto
            {
                LibroId = libro.LibroId,
                Titulo = libro.Titulo,
                Genero = libro.Genero!.NombreGenero
            };
        }

        public static List<LibroListDto> MapearLista(List<Libro> libros)
        {
            return libros.Select(MapearListDto).ToList();
            //return libros.Select(l => MapearListDto(l)).ToList();
        }
        public static Libro MapearEntidad(LibroEditDto libroDto)
        {
            return new Libro
            {
                LibroId = libroDto.LibroId,
                Titulo = libroDto.Titulo,
                Sinopsis = libroDto.Sinopsis,
                GeneroId = libroDto.GeneroId
            };
        }
    }
}
