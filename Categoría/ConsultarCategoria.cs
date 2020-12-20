using sistema_de_facturacion.Modelo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Runtime.InteropServices;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sistema_de_facturacion.Categoría
{
    public partial class ConsultarCategoria : Form
    {
        public Form inicial;
        Categoria buscar = new Categoria();


        public ConsultarCategoria(Form interfazInicial)
        {
            InitializeComponent();
            this.inicial = interfazInicial;
            cargarTabla();
        }
        public void cargarTabla()
        {
            categoriasGrid.DataSource = buscar.buscarCategoria("");
        }
        private void AgregarB_Click(object sender, EventArgs e)
        {
            new AgregarCategoria(inicial).Visible = true;
            this.Visible = false;
        }
       

        private void CancelarB_Click(object sender, EventArgs e)
        {
            inicial.Visible = true;
            this.Close();
        }

        private void ModificarB_Click(object sender, EventArgs e)
        {
            if (categoriasGrid.SelectedRows.Count > 0)
            {
                string nombre = categoriasGrid.SelectedRows[0].Cells[1].Value.ToString();
                Categoria obtenida = buscar.obtenerCategoria(nombre);
                new AgregarCategoria(true, inicial, obtenida).Visible = true;
                this.Visible = false;
            }
            else
            {
                MessageBox.Show("Seleccione al menos una categoría de la tabla.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void CerrarButton_Click(object sender, EventArgs e)
        {
            inicial.Visible = true;
            this.Close();
        }

        private void ParametroField_KeyPress(object sender, KeyPressEventArgs e)
        {
            
        }
        public bool IsNaturalNumber(String cadena)
        {
            Regex objNaturalPattern = new Regex("[$/&+,':;=?@#|]");
            return objNaturalPattern.IsMatch(cadena);
        }

        private void ParametroField_KeyDown(object sender, KeyEventArgs e)
        {
            
        }

        private void ParametroField_SizeChanged(object sender, EventArgs e)
        {
           
        }

        private void ParametroField_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            
        }

        private void ParametroField_KeyUp(object sender, KeyEventArgs e)
        {
            if (new Validacion().caracteres(parametroField))
            {
                MessageBox.Show("No se permiten caracteres especiales");
                e.Handled = true;
                parametroField.Clear();
            }
            else
            {
                categoriasGrid.DataSource = buscar.buscarCategoria(parametroField.Text.TrimEnd());
            }
        }
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);
        private void ConsultarCategoria_MouseDown(object sender, MouseEventArgs e)
        {
            
        }

        private void Panel1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
    }
}
