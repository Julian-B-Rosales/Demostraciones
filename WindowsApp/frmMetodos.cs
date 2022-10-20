using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsApp
{
    public partial class frmMetodos : Form
    {
        public frmMetodos()
        {
            InitializeComponent();
        }

        private void btnImprimir_Click(object sender, EventArgs e)
        {
            show();
        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {
            show("Julian", "Rosales");
        }

        #region Mis Metodos
        private void show()
        {
            MessageBox.Show("Bienvenido!");
        }

        private void show(string nombre)
        {
            MessageBox.Show("Bienvenido " + nombre);
        }

        private void show(string nombre, string apellido)
        {
            MessageBox.Show("Bienvenido " + nombre + " " + apellido);
        }

        #endregion
    }
}
