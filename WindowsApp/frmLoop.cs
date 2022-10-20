using System;
using System.Windows.Forms;
using Microsoft.VisualBasic;

namespace WindowsApp
{
    public partial class frmLoop : Form
    {
        public frmLoop()
        {
            InitializeComponent();
        }

        private void btnPruebaLoop_Click(object sender, EventArgs e)
        {

            int total = 0;

            MessageBox.Show("Ingresar 10 numeros enteros menores a 100");

            for (int i = 0; i < 10; i++)
            {
                
                int numero = Convert.ToInt32(Interaction.InputBox("Ingrese numero: "));
                while (numero >= 100)
                {
                    MessageBox.Show("Error. Ingrese numeros menores a 100");

                    numero = Convert.ToInt32(Interaction.InputBox("Ingrese numero: "));
                }

                total += numero;

            }

            MessageBox.Show("Total: " + total.ToString());

        }
    }
}
