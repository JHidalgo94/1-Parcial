using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _1parcial
{
    public partial class Ejercoicio1 : Form
    {
        public Ejercoicio1()
        {
            InitializeComponent();
        }

        private void numero1textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void sumarbutton1_Click(object sender, EventArgs e)
        {
            decimal numero1 = Convert.ToDecimal (numero1textBox1.Text);
            decimal numero2 = Convert.ToDecimal(numero2textBox2.Text);

            decimal resultado = numero1 + numero2;

            MessageBox.Show("La suma es " + resultado);
        }
    }
}
