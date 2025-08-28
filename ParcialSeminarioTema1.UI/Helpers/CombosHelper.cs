using ParcialSeminarioTema1.Servicios.DTOs.Genero;
using ParcialSeminarioTema1.Servicios.Interfaces;

namespace ParcialSeminarioTema1.UI.Helpers
{
    public static class CombosHelper
    {
        public static void CargarComboGeneros(ref ComboBox cbo, IGenerosServicio _generoServicio)
        {
            var generos = _generoServicio.ObtenerLista();
            var defaultGenero = new GeneroListDto
            {
                GeneroId = 0,
                NombreGenero = "<Seleccione Género>"
            };
            generos.Insert(0,defaultGenero);
            cbo.DataSource= generos;
            cbo.DisplayMember = "NombreGenero";
            cbo.ValueMember = "GeneroId";
            cbo.SelectedIndex = 0;
        }

    }
}
