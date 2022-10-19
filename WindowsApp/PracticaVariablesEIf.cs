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
    public partial class PracticaVariablesEIf : Form
    {
        public PracticaVariablesEIf()
        {
            InitializeComponent();
            
        }

        private void PracticaVariablesEIf_Load(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void btnMayorNota_Click(object sender, EventArgs e)
        {
            decimal nota1 = Convert.ToDecimal(txtNota1.Text);
            decimal nota2 = Convert.ToDecimal(txtNota2.Text);
            decimal nota3 = Convert.ToDecimal(txtNota3.Text);
            decimal nota4 = Convert.ToDecimal(txtNota4.Text);

            if (nota1 > nota2 && nota1 > nota3 && nota1 > nota4)
            {
                MessageBox.Show("La mayor nota es: " + nota1);
            }
            else if(nota2 > nota1 && nota2 > nota3 && nota2 > nota4)
            {
                MessageBox.Show("La mayor nota es: " + nota2);
            }
            else if (nota3 > nota1 && nota3 > nota2 && nota3 > nota4)
            {
                MessageBox.Show("La mayor nota es: " + nota3);
            }
            else
            {
                MessageBox.Show("La mayor nota es: " + nota4);
            }
        }

        private void btnPromediar_Click(object sender, EventArgs e)
        {
            decimal nota1 = Convert.ToDecimal(txtNota1.Text);
            decimal nota2 = Convert.ToDecimal(txtNota2.Text);
            decimal nota3 = Convert.ToDecimal(txtNota3.Text);
            decimal nota4 = Convert.ToDecimal(txtNota4.Text);

            decimal prom = (nota1 + nota2 + nota3 + nota4) / 4;

            if (prom >= 9)
            {
                MessageBox.Show("Excelente! \nEl promedio es: " + prom);
            }
            else if (prom < 9 && prom >= 7)
            {
                MessageBox.Show("Muy bien! \nEl promedio es: " + prom);
            }
            else if (prom < 7 && prom >= 4)
            {
                MessageBox.Show("Regular. \nEl promedio es: " + prom);
            }
            else
            {
                MessageBox.Show("En proceso de aprendizaje.\nEl promedio es: " + prom);
            }
        }
    }
}
