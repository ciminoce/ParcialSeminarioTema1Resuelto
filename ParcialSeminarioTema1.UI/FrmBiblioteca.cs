using ParcialSeminarioTema1.Servicios.DTOs.Genero;
using ParcialSeminarioTema1.Servicios.DTOs.Libro;
using ParcialSeminarioTema1.Servicios.Interfaces;
using ParcialSeminarioTema1.UI.Helpers;

namespace ParcialSeminarioTema1.UI
{
    public partial class FrmBiblioteca : Form
    {
        private readonly ILibrosServicio _librosServicio;
        private readonly IGenerosServicio _generosServicio;
        private List<LibroListDto>? librosDto;
        private int cantidadRegistros;

        public FrmBiblioteca(ILibrosServicio librosServicio, IGenerosServicio generosServicio)
        {
            _librosServicio = librosServicio;
            _generosServicio = generosServicio;
            InitializeComponent();
        }


        private void FrmBiblioteca_Load(object sender, EventArgs e)
        {
            RecargarGrilla();
        }

        private void MostrarCantidad()
        {
            TxtRegistros.Text = cantidadRegistros.ToString();
        }

        private void TsbCerrar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void TsbNuevo_Click(object sender, EventArgs e)
        {
            using (var frm = new FrmLibrosAE(_generosServicio) { Text = "Agregar Libro" })
            {
                DialogResult dr = frm.ShowDialog(this);
                if (dr == DialogResult.Cancel) return;
                LibroEditDto? libroEditDto = frm.GetLibro();
                if (libroEditDto is null) return;
                try
                {
                    var libroListDto = _librosServicio.Guardar(libroEditDto, out var errores);
                    if (libroListDto is not null)
                    {
                        var r = GridHelper.ConstruirFila(dgvDatos);
                        GridHelper.SetearFila(r, libroListDto);
                        GridHelper.AgregarFila(r, dgvDatos);
                        MessageBox.Show("Registro Agregado");
                        cantidadRegistros = _librosServicio.ObtenerCantidad();
                        MostrarCantidad();

                    }
                    else
                    {
                        MessageBox.Show(errores.First(), "Errores");
                    }
                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.Message, "Errores");
                }
            }
        }

        private void TsbFiltrar_Click(object sender, EventArgs e)
        {
            using (var frm = new FrmFiltro() { Text = "Filtrar Por Género" })
            {
                DialogResult dr = frm.ShowDialog(this);
                if (dr == DialogResult.Cancel) return;
                string? filtroGenero = frm.GetFiltro();
                if (string.IsNullOrEmpty(filtroGenero)) return;
                GeneroListDto? generoListDto = _generosServicio.ObtenerGeneroPorNombre(filtroGenero);
                if (generoListDto is null)
                {
                    MessageBox.Show("Género inexistente");
                    return;
                }
                try
                {
                    librosDto = _librosServicio.ObtenerLista(generoListDto.GeneroId);
                    GridHelper.MostrarDatosEnGrilla<LibroListDto>(librosDto, dgvDatos);
                    cantidadRegistros = _librosServicio.ObtenerCantidad(generoListDto.GeneroId);
                    MostrarCantidad();
                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.Message, "Error");
                }
            }
        }

        private void TsbActualizar_Click(object sender, EventArgs e)
        {
            RecargarGrilla();
        }

        private void RecargarGrilla()
        {
            try
            {
                librosDto = _librosServicio.ObtenerLista();
                cantidadRegistros = _librosServicio.ObtenerCantidad();
                GridHelper.MostrarDatosEnGrilla<LibroListDto>(librosDto, dgvDatos);
                MostrarCantidad();
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void TsbBorrar_Click(object sender, EventArgs e)
        {
            if (dgvDatos.SelectedRows.Count==0)
            {
                return;
            }
            var r=dgvDatos.SelectedRows[0];
            LibroListDto libroDto = (LibroListDto)r.Tag!;
            DialogResult dr=MessageBox.Show($"¿Confirma la baja de {libroDto.Titulo}?",
                "Confirmar Operación",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question,
                MessageBoxDefaultButton.Button2);
            if (dr == DialogResult.No) return;
            try
            {
                var resultado = _librosServicio.Eliminar(libroDto.LibroId);
                if (resultado.exito)
                {
                    GridHelper.QuitarFila(r,dgvDatos);
                    cantidadRegistros = _librosServicio.ObtenerCantidad();
                    MostrarCantidad();
                    MessageBox.Show(resultado.mensaje, "Éxito",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show(resultado.mensaje, "Error!!",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Error!!",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
