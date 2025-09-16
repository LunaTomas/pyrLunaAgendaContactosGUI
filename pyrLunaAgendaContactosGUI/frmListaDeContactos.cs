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
        public string[] vecNombres;
        public string[] vecNumeros;
        int indice = 0;
        public frmListaDeContactos()
        {
            InitializeComponent();
        }
        private void frmListaDeContactos_Load(object sender, EventArgs e)
        {
            lblNombre.Text = vecNombres[0];
            lblNumero.Text = vecNumeros[0];
            btnAnterior.Enabled = false;
            if (vecNombres.Length == 1 || vecNombres[1] == null)
            {
                btnSiguiente.Enabled = false;
            }
        }
        private void btnSiguiente_Click(object sender, EventArgs e)
        {
            //hacer que el boton se desactive cuando llegue a la ultima posicion del vector que no sea null
            if (indice + 1 < vecNombres.Length && vecNombres[indice + 1] != null)
            {
                indice++;
                lblNombre.Text = vecNombres[indice];
                lblNumero.Text = vecNumeros[indice];
                btnAnterior.Enabled = true;
            }
            if (indice + 1 >= vecNombres.Length || vecNombres[indice + 1] == null)
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
