using ParcialSeminarioTema1.Servicios.DTOs.Libro;
using ParcialSeminarioTema1.Servicios.Interfaces;
using ParcialSeminarioTema1.UI.Helpers;

namespace ParcialSeminarioTema1.UI
{
    public partial class FrmLibrosAE : Form
    {
        private IGenerosServicio _generosServicio;
        private LibroEditDto? libroDto;
        public FrmLibrosAE(IGenerosServicio generosServicio)
        {
            InitializeComponent();
            _generosServicio = generosServicio;
        }
        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            CombosHelper.CargarComboGeneros(ref CboGeneros, _generosServicio);
            if (libroDto is null)
            {
                TxtCodigo.Text = "(NUEVO)";
            }
            else
            {
                TxtCodigo.Text = libroDto.LibroId.ToString();
                TxtTitulo.Text = libroDto.Titulo;
                TxtSinopsis.Text = libroDto.Sinopsis;
                CboGeneros.SelectedValue = libroDto.GeneroId;
            }
        }

        public LibroEditDto? GetLibro()
        {
            return libroDto;
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private void BtnOk_Click(object sender, EventArgs e)
        {
            if (ValidarDatos())
            {
                if(libroDto is null)
                {
                    libroDto=new LibroEditDto();
                }
                libroDto.Titulo = TxtTitulo.Text;
                libroDto.Sinopsis = TxtSinopsis.Text;
                libroDto.GeneroId = (int)CboGeneros.SelectedValue!;

                DialogResult = DialogResult.OK;
            }

        }

        private bool ValidarDatos()
        {
            bool valido = true;
            errorProvider1.Clear();
            if (string.IsNullOrEmpty(TxtTitulo.Text))
            {
                valido = false;
                errorProvider1.SetError(TxtTitulo, "El titulo es requerido");
            }
            if (CboGeneros.SelectedIndex == 0) {
                valido = false;
                errorProvider1.SetError(CboGeneros, "Debe seleccionar un género");
            }
            return valido;
        }
    }
}
