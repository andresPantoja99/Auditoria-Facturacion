using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using sistema_de_facturacion.Modelo;

namespace sistema_de_facturacion.Categoría
{
    public partial class AgregarCategoria : Form
    {
        public Form inicial;
        public List<TextBox> fieldList = new List<TextBox>();
        Categoria modificar = new Categoria();
        Boolean mod = false;
        public AgregarCategoria(Form interfazInicial)
        {
            InitializeComponent();
            this.inicial = interfazInicial;
        }
        public AgregarCategoria(Boolean mod,Form interfazInicial,Categoria categoria)
        {
            InitializeComponent();
            this.modificar = categoria;
            this.inicial = interfazInicial;
            nombreField.Text = categoria.nombre;
            this.mod = true;
            agregarB.Text = "Guardar Cambios";
            labelIngreso.Text = "Modificación de categorias";
        }

        private void MinimizarButton_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void MaximizarButton_Click(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Maximized)
            {
                this.WindowState = FormWindowState.Normal;
            }
            else
            {
                this.WindowState = FormWindowState.Maximized;
            }
        }

        private void CerrarButton_Click(object sender, EventArgs e)
        {
            inicial.Visible = true;
            this.Close();
        }
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);
        private void Panel1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void TableLayoutPanel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void AgregarB_Click(object sender, EventArgs e)
        {
            if (mod == false)
            {
                fieldList.Add(nombreField);
                Boolean lleno = false;
                foreach (TextBox singleItem in fieldList)
                {
                    if (singleItem.Text.Equals(""))
                    {
                        lleno = true;
                        break;
                    }

                }
                if (lleno)
                {
                    MessageBox.Show("Se requiere llenar todos los campos.");
                }
                else
                {
                    Categoria nueva = new Categoria(nombreField.Text);
                    int hecho = nueva.agregarCategoria(nueva);
                    if (hecho == 0)
                    {
                        MessageBox.Show("Categoría registrada exitosamente.");
                        inicial.Visible = true;
                        this.Close();
                    }
                    else if (hecho == -1)
                    {
                        MessageBox.Show("La categoría especificada ya se encuentra registrada.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    }
                    else
                    {
                        MessageBox.Show("Se produjo un error al registrar la categoría.");
                    }
                }
            }
            else
            {
                if (nombreField.Text.Equals(""))
                {
                    MessageBox.Show("Se requiere llenar todos los campos.");
                }
                else
                {
                    Categoria nuevo = new Categoria(nombreField.Text);
                    if (modificar.modificarCategoria(this.modificar,nuevo) == 0)
                    {
                        MessageBox.Show("Cambios guardados.");
                        this.Visible = false;
                        inicial.Visible = true;
                    }
                    else
                    {
                        MessageBox.Show("Se produjo un error al guardar los cambios.");
                    }
                }
            }
        }

        private void CancelarB_Click(object sender, EventArgs e)
        {
            inicial.Visible = true;
            this.Close();
        }

        private void NombreField_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsLetter(e.KeyChar)) && (e.KeyChar != (char)Keys.Back) && (e.KeyChar != (char)Keys.Space))
            {
                ToolTip tt = new ToolTip();
                tt.IsBalloon = true;
                tt.Show("Ingrese únicamente letras.", nombreField, 0, -40, 2000);
                e.Handled = true;
                return;
            }
        }
    }
}
