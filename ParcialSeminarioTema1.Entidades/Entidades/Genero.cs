namespace ParcialSeminarioTema1.Entidades.Entidades
{
    public class Genero
    {
        public int GeneroId { get; set; }
        public string NombreGenero { get; set; } = null!;
        public List<Libro> Libros { get; set; } = new();
    }
}
