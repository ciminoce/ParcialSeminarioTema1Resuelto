using ParcialSeminarioTema1.Servicios.DTOs.Genero;
using ParcialSeminarioTema1.Servicios.DTOs.Libro;

namespace ParcialSeminarioTema1.UI.Helpers
{
    public static class GridHelper
    {
        /// <summary>
        /// Método estático genérico para desplegar
        /// los datos de la lista en la grilla
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="lista"></param>
        /// <param name="grid"></param>
        public static void MostrarDatosEnGrilla<T>(List<T> lista, DataGridView grid) where T : class
        {
            LimpiarGrilla(grid);
            foreach (T item in lista)
            {
                var row = ConstruirFila(grid);
                SetearFila(row, item);
                AgregarFila(row, grid);
            }
        }

        /// <summary>
        /// Método estático para limpiar una grilla
        /// </summary>
        /// <param name="grid">Grilla que se desea limpiar</param>
        public static void LimpiarGrilla(DataGridView grid)
        {
            grid.Rows.Clear();
        }
        /// <summary>
        /// Método estático para construir una nueva fila
        /// de la grilla que me pasan
        /// </summary>
        /// <param name="grid">Grilla a la cual le creo la fila</param>
        /// <returns>Fila de la grilla resultante</returns>
        public static DataGridViewRow ConstruirFila(DataGridView grid)
        {
            DataGridViewRow r = new DataGridViewRow();
            r.CreateCells(grid);
            return r;
        }
        /// <summary>
        /// Método estático para setear la fila de la grilla
        /// con el contenido del objeto que me pasan
        /// </summary>
        /// <param name="r">Fila a popular</param>
        /// <param name="obj">objeto que se muestra</param>
        public static void SetearFila(DataGridViewRow r, object obj)
        {
            switch (obj)
            {
                case LibroListDto libroDto:
                    r.Cells[0].Value = libroDto.LibroId;
                    r.Cells[1].Value = libroDto.Titulo;
                    r.Cells[2].Value = libroDto.Genero;
                    break;
                case GeneroListDto generoDto:
                    r.Cells[0].Value = generoDto.GeneroId;
                    r.Cells[1].Value = generoDto.NombreGenero;
                    break;
            }

            r.Tag = obj;
        }
        /// <summary>
        /// Método estático para agregar una fila a una grilla
        /// </summary>
        /// <param name="r">Fila a agregar</param>
        /// <param name="grid">Grilla en la cual se agrega la fila</param>
        public static void AgregarFila(DataGridViewRow r, DataGridView grid)
        {
            grid.Rows.Add(r);
        }
        /// <summary>
        /// Método estático para eliminar una fila a una grilla
        /// </summary>
        /// <param name="r">Fila a eliminar</param>
        /// <param name="grid">Grilla en la cual se desea quitar la fila</param>
        public static void QuitarFila(DataGridViewRow r, DataGridView grid)
        {
            grid.Rows.Remove(r);
        }
    }
}
