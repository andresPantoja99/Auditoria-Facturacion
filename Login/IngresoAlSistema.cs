using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using sistema_de_facturacion.Principal;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using sistema_de_facturacion.Modelo;
using sistema_de_facturacion.Huella;

namespace sistema_de_facturacion.Login
{
    public partial class IngresoAlSistema : Form
    {
        public List<TextBox> fieldList = new List<TextBox>();
        
        Usuario verificar = new Usuario();
        public String usuario;
        int intentos = 0;
        public IngresoAlSistema()
        {
            InitializeComponent();
            
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            ingresarSistema();
        }
        private void ingresarSistema()
        {
            fieldList.Add(usuarioField);
            fieldList.Add(passwordField);
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
                String[] datos = new String[3];
                datos[0] = usuarioField.Text.TrimEnd();
                datos[1] = passwordField.Text.TrimEnd();
                datos[2] = ""; //Huella
                if (intentos >= 3)
                {
                    MessageBox.Show("Ha superado los tres intentos de sesión.");
                    Application.Exit();
                }
                else if (verificar.validarIngreso(datos,0)==1)
                {
                    //Aquí se le pasa el nombre de usuario a la interfaz principal para obtener el usuario y su rol.
                    Usuario obtenido = verificar.obtenerUsuario(datos[0]);
                    Form principal = new InterfazInicial(obtenido);
                    principal.Visible = true;
                    this.Visible = false;
                }
                else
                {
                    MessageBox.Show("Usuario o contraseña incorrectos.");
                    intentos++;
                }
            }
        }
        public void ingresarConHuella()
        {
            Usuario obtenido = verificar.obtenerUsuario(this.usuario);
            Form principal = new InterfazInicial(obtenido);
            principal.Visible = true;
            this.Visible = false;
        }
        private void PasswordField_TextChanged(object sender, EventArgs e)
        {

        }

        private void PasswordField_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                ingresarSistema();
            }
        }

        private void Cerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
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

        private void HuellaButton_Click(object sender, EventArgs e)
        {
            new Huellas(this).Visible = true;
            this.Visible = false;
        }
    }
}
