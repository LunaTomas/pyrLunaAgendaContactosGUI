namespace pyrLunaAgendaContactosGUI
{
    public partial class frmAgendar : Form
    {
        public string[] vecNombres = new string[7];
        public string[] vecNumeros = new string[7];
        int indice = 0;
        public frmAgendar()
        {
            InitializeComponent();
        }
        private void frmAgendar_Load(object sender, EventArgs e)
        {
            vecNombres[0] = "Max Verstappen";
            vecNumeros[0] = "123456789";
            vecNombres[1] = "Lewis Hamilton";
            vecNumeros[1] = "987654321";
            vecNombres[2] = "Lando Norris";
            vecNumeros[2] = "456123789";
            vecNombres[3] = "Fernando Alonso";
            vecNumeros[3] = "789456123";
            vecNombres[4] = "Franco Colapinto";
            vecNumeros[4] = "321654987";
            //poner los nombres en la lista
            while (vecNombres[indice] != null)
            {
                lstRegistro.Items.Add(vecNombres[indice] + " - " + vecNumeros[indice]);
                indice++;
            }
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
            //cuando el vector este lleno , desactivar el boton agendar y mostrar un mensaje
            if (indice == vecNombres.Length)
            {
                txtNombre.Enabled = false;
                mskNumero.Enabled = false;
                btnAgendar.Enabled = false;
                MessageBox.Show("La agenda esta llena, no se pueden agregar mas contactos", "Agenda llena", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
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
            frmListaDeContactos.vecNombres = vecNombres;
            frmListaDeContactos.vecNumeros = vecNumeros;
            frmListaDeContactos.ShowDialog();
        }
    }
}