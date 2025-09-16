using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pyrLunaAgendaContactosGUI
{
    public partial class frmPrueba : Form
    {
        public frmPrueba()
        {
            InitializeComponent();
        }
        //arreglar esto mas tarde que nose que hice XD

        //añadir vector y meterle datos dentro
        string[] vecNombres = new string[5];
        int indice = 0;
        private void frmPrueba_Load(object sender, EventArgs e)
        {
            vecNombres[0] = "Ana";
            vecNombres[1] = "Luis";
            vecNombres[2] = "Pepe";
            //mostrar en el listbox
            while (indice < 3)
            {
                lstNombres.Items.Add(vecNombres[indice]);
                indice++;
            }
        }

        private void btnOriginal_Click(object sender, EventArgs e)
        {

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            //agregar nuevo nombre al vector
            if (txtNombre.Text != "")
            {
                lstNombres.Items.Add(txtNombre.Text);
                txtNombre.Clear();
                txtNombre.Focus();
            }
            else
            {
                MessageBox.Show("Debe ingresar un nombre");
                txtNombre.Focus();
            }
        }
    }
}
