namespace pyrLunaAgendaContactosGUI
{
    public partial class frmAgendar : Form
    {
        string[] vecNombres = new string[100];
        string[] vecNumeros = new string[100];
        int indice = 0;
        public frmAgendar()
        {
            InitializeComponent();
        }
        private void frmAgendar_Load(object sender, EventArgs e)
        {
            lblCantidadContactos.Text = "Cantidad de contactos: 0";
            lblFechaYHora.Text = "Ultimo registro: Ninguno";
            mskNumero.Enabled = false;
            btnAgendar.Enabled = false;
            txtNombre.Focus();
        }
        private void txtNombre_TextChanged(object sender, EventArgs e)
        {
            //activar el maskedtextbox cuando el textbox tenga al menos 1 caracter
            if (txtNombre.Text.Length > 0)
            {
                mskNumero.Enabled = true;
            }
            else
            {
                mskNumero.Enabled = false;
                btnAgendar.Enabled = false;
                mskNumero.Clear();
            }
        }
        private void mskNumero_TextChanged(object sender, EventArgs e)
        {
            //activar el boton agendar cuando el maskedtextbox tenga minimo 1 numero
            if (mskNumero.Text.Length == 13)
            {
                btnAgendar.Enabled = true;
            }
            else
            {
                btnAgendar.Enabled = false;
            }
        }
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            txtNombre.Clear();
            mskNumero.Clear();
        }
        private void btnAgendar_Click(object sender, EventArgs e)
        {
            vecNombres[indice] = txtNombre.Text;
            vecNumeros[indice] = mskNumero.Text;
            indice++;
            lstRegistro.Items.Add(txtNombre.Text + " - " + mskNumero.Text);
            lblCantidadContactos.Text = "Cantidad de contactos: " + lstRegistro.Items.Count;
            lblFechaYHora.Text = "Ultimo registro: " + DateTime.Now.ToString();
            txtNombre.Clear();
            mskNumero.Clear();
            txtNombre.Focus();
            mskNumero.Enabled = false;
            btnAgendar.Enabled = false;
        }
        private void btnVerListaDeContactos_Click_1(object sender, EventArgs e)
        {
            frmListaDeContactos frmListaDeContactos = new frmListaDeContactos();
            frmListaDeContactos.ShowDialog();
        }
    }
}