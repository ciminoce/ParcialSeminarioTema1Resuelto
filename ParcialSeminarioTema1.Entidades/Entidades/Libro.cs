namespace ParcialSeminarioTema1.Entidades.Entidades
{
    public class Libro
    {
        public int LibroId { get; set; }
        public string Titulo { get; set; } = null!;
        public string? Sinopsis { get; set; }
        public int GeneroId { get; set; }

        public Genero Genero { get; set; } = null!;
    }
}
