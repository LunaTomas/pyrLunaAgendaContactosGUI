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
    public partial class frmListaDeContactos : Form
    {
        public string[] vecNombres = new string[100];
        public string[] vecNumeros = new string[100];
        int indice = 0;
        public frmListaDeContactos()
        {
            InitializeComponent();
        }

        private void frmListaDeContactos_Load(object sender, EventArgs e)
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
            lblNombre.Text = vecNombres[0];
            lblNumero.Text = vecNumeros[0];
            btnAnterior.Enabled = false;
        }

        private void btnSiguiente_Click(object sender, EventArgs e)
        {
            //hacer que el boton se desactive cuando llegue a la ultima posicion del vector que no sea null
            if (vecNombres[indice + 1] != null)
            {
                indice++;
                lblNombre.Text = vecNombres[indice];
                lblNumero.Text = vecNumeros[indice];
                btnAnterior.Enabled = true;
            }
            if (vecNombres[indice + 1] == null)
            {
                btnSiguiente.Enabled = false;
            }
        }
        private void btnAnterior_Click(object sender, EventArgs e)
        {
            if (indice > 0)
            {
                indice--;
                lblNombre.Text = vecNombres[indice];
                lblNumero.Text = vecNumeros[indice];
                btnSiguiente.Enabled = true;
            }
            if (indice == 0)
            {
                btnAnterior.Enabled = false;
            }
        }
    }
}
