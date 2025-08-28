namespace ParcialSeminarioTema1.Servicios.DTOs.Libro
{
    public class LibroEditDto
    {
        public int LibroId { get; set; }
        public string Titulo { get; set; } = null!;
        public string? Sinopsis { get; set; }
        public int GeneroId { get; set; }

    }
}
