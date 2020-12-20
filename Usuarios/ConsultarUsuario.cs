using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using sistema_de_facturacion.Modelo;
using System.Threading;

namespace sistema_de_facturacion.Usuarios
{
    public partial class ConsultarUsuario : Form
    {
        public Form inicial;
        public String tipo;
        Usuario buscar = new Usuario();
       public ConsultarUsuario()
        {

        }
        public ConsultarUsuario(String type, Form interfazInicial)
        {
            InitializeComponent();
            this.inicial = interfazInicial;
            this.tipo = type;
            usuarioGrid.Update();
            usuarioGrid.Refresh();
            labelAdvertencia.Visible = false;
            parametroBox.SelectedIndex = 0;
            cargarUsuarios();
            if (type.Equals("consultar"))
            {
                labelIngreso.Text = "Búsqueda de Usuarios";
                accionButton.Visible = false;
            }
            if (type.Equals("modificar"))
            {
                labelIngreso.Text = "Modificación de usuarios";
                accionButton.Text = "Modificar Rol del usuario";
            }
            if (type.Equals("eliminar"))
            {
                labelIngreso.Text = "Eliminación de Usuarios";
                accionButton.Text = "Eliminar usuario seleccionado";
            }
        }
        
        private void cargarUsuarios()
        {
            usuarioGrid.DataSource = buscar.buscarUsuario(0, "");
        }
        private void AccionV_Click(object sender, EventArgs e)
        {
            if (usuarioGrid.SelectedRows.Count > 0 && tipo.Equals("modificar")) //Cambiar a 0.
            {
                //Obtengo el usuario y despliego ventana con información.
                string usuario = usuarioGrid.SelectedRows[0].Cells[0].Value.ToString();
                Usuario rol = buscar.obtenerUsuario(usuario);
                new AgregarUsuario(rol,true, inicial).Visible = true;
                this.Visible = false;
            }
            if (usuarioGrid.SelectedRows.Count > 0 && tipo.Equals("eliminar")) //Cambiar a 0.
            {
                //Elimino el usuario seleccionado.
                string usuario = usuarioGrid.SelectedRows[0].Cells[0].Value.ToString();
                if (MessageBox.Show("¿Está seguro de eliminar al usuario seleccionado?", "Advertencia", MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    if (buscar.eliminarUsuario(usuario) == 0)
                    {
                        MessageBox.Show("Usuario eliminado exitosamente.");
                        cargarUsuarios();
                    }
                    else
                    {
                        MessageBox.Show("Error al eliminar el usuario seleccionado.");
                    }
                }
            }
        }

        private void Cerrar_Click(object sender, EventArgs e)
        {
            inicial.Visible = true;
            this.Close();
        }

        private void Maximizar_Click(object sender, EventArgs e)
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
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);
        private void Minimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void Panel1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            inicial.Visible = true;
            this.Close();
        }

        private void LabelIngreso_Click(object sender, EventArgs e)
        {

        }

        private void ParametroField_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (parametroBox.Text.Length > 0)
            {
                labelAdvertencia.Visible = false;
                usuarioGrid.DataSource = buscar.buscarUsuario(parametroBox.SelectedIndex, parametroField.Text);
            }
            else
            {
                labelAdvertencia.Visible = true;
                parametroField.Clear();
            }
        }

        private void TableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void ParametroField_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            
        }

        private void ParametroField_KeyDown(object sender, KeyEventArgs e)
        {

        }

        private void ParametroField_KeyUp(object sender, KeyEventArgs e)
        {

            if (parametroBox.Text.Length > 0)
            {
                labelAdvertencia.Visible = false;
                usuarioGrid.DataSource = buscar.buscarUsuario(parametroBox.SelectedIndex, parametroField.Text);
            }
            else
            {
                labelAdvertencia.Visible = true;
                parametroField.Clear();
            }
        }
    }
}
