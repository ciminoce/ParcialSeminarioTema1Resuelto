using ParcialSeminarioTema1.Servicios.DTOs.Genero;
using ParcialSeminarioTema1.Servicios.Interfaces;
using ParcialSeminarioTema1.UI.Helpers;

namespace ParcialSeminarioTema1.UI
{
    public partial class FrmGeneros : Form
    {
        private readonly IGenerosServicio _generoServicio;
        private List<GeneroListDto>? lista;
        private GeneroListDto? generoSeleccionado;
        public FrmGeneros(IGenerosServicio generoServicio)
        {
            InitializeComponent();
            _generoServicio = generoServicio;
        }

        private void FrmGeneros_Load(object sender, EventArgs e)
        {
            try
            {
                lista = _generoServicio.ObtenerLista();
                GridHelper.MostrarDatosEnGrilla<GeneroListDto>(lista, dgvDatos);
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Error!!",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgvDatos_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            // 1. Verificar si el doble clic ocurrió en una fila válida (no en el encabezado de columna/fila)
            if (e.RowIndex >= 0)
            {
                // 2. Obtener la fila seleccionada
                var filaSeleccionada = dgvDatos.Rows[e.RowIndex];
                generoSeleccionado = (GeneroListDto)filaSeleccionada.Tag!;
                DialogResult = DialogResult.OK;
            }
        }
        public GeneroListDto? GetGenero()
        {
            return generoSeleccionado;
        }
    }
}
