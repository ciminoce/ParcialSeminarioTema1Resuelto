namespace ParcialSeminarioTema1.UI
{
    public partial class FrmFiltro : Form
    {
        private string? filtro;
        public FrmFiltro()
        {
            InitializeComponent();
        }

        public string? GetFiltro()
        {
            return filtro;
        }

        private void BtnOk_Click(object sender, EventArgs e)
        {
            if (ValidarDatos())
            {
                filtro = TxtGenero.Text;

                DialogResult = DialogResult.OK;
            }
        }

        private bool ValidarDatos()
        {
            bool valido = true;
            errorProvider1.Clear();
            if (string.IsNullOrEmpty(TxtGenero.Text))
            {
                valido = false;
                errorProvider1.SetError(TxtGenero, "Debe ingresar un género");
            }
            return valido;
        }
    }
}
