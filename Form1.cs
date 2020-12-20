using sistema_de_facturacion.Modelo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sistema_de_facturacion
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void TextBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (new Validacion().caracteres(textBox1))
            {
                MessageBox.Show("No se permiten caracteres especiales");
                e.Handled = true;
                textBox1.Clear();
            }
            else
            {
                MessageBox.Show("OK");
            }
        }
    }
}
