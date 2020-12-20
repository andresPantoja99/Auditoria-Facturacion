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
using sistema_de_facturacion.Huella;

namespace sistema_de_facturacion.Usuarios
{
    public partial class AgregarUsuario : Form
    {
        public Form inicial;
        public List<TextBox> fieldList = new List<TextBox>();
        public Boolean rol, valido;
        public Boolean modificar;
        public Usuario obtenido = new Usuario();
        public Validacion validar = new Validacion();
        public byte[] huella;
        int VisibleTime = 1750;
        public AgregarUsuario(Form interfazInicial)
        {
            InitializeComponent();
            this.inicial = interfazInicial;
            usuarioBox.SelectedIndex = 0;
        }
        public AgregarUsuario(Usuario obtenido,Boolean modificacion, Form ventana)
        {
            InitializeComponent();
            this.modificar = modificacion;
            this.rol = true;
            this.obtenido = obtenido;
            this.inicial = ventana;
            modificarF();
        }
        public AgregarUsuario(Usuario obtenido, Form ventana)
        {
            InitializeComponent();
            this.inicial = ventana;
            this.obtenido = obtenido;
            this.modificar = true;
            modificarMis();
            
        }
        public void modificarMis()
        {
            usuarioBox.Enabled = false;
            huellaButton.Enabled = false;
            nombreField.Enabled = false;
            nombresField.Enabled = false;
            apellidoField.Enabled = false;
            labelPassword.Text = "Nueva Contraseña:";
            registrarButton.Text = "Guardar Cambios";
            limpiarButton.Visible = false;
            labelIngreso.Text = "Modificación de Usuarios";
            establecerDatos();
        }
        public void establecerDatos()
        {
            nombreField.Text = obtenido.usuario;
            passwordField.Text = "";
            nombresField.Text = obtenido.nombres;
            if (obtenido.rol.Equals("Gerente"))
            {
                usuarioBox.SelectedIndex = 0;
            } else if (obtenido.rol.Equals("Vendedor"))
            {
                usuarioBox.SelectedIndex = 1;
            } else if (obtenido.rol.Equals("Bodeguero"))
            {
                usuarioBox.SelectedIndex = 2;
            }
            apellidoField.Text = obtenido.apellidos;
        }
        public void modificarF()
        {
            
            huellaButton.Enabled = false;
            nombreField.Enabled = false;
            nombresField.Enabled = false;
            passwordField.Enabled = false;
            apellidoField.Enabled = false;
            registrarButton.Text = "Guardar Cambios";
            limpiarButton.Visible = false;
            labelIngreso.Text = "Modificación de Rol";
            establecerDatos();
            passwordField.Text = obtenido.contrasena;
        }
        private void Cerrar_Click(object sender, EventArgs e)
        {
            inicial.Visible = true;
            this.Close();
        }

        private void RegistrarButton_Click(object sender, EventArgs e)
        {

            
            int selected = usuarioBox.SelectedIndex;
            if (modificar == false)
            {
                
                
                if (camposVacios())
                {
                    MessageBox.Show("Se requiere llenar todos los campos.");
                }
                else
                {
                    if (verificarCampos()) {
                        MessageBox.Show("Llene correctamente todos los campos.");
                    } else {
                        if(this.huella != null)
                        {
                            Usuario user = new Usuario(nombreField.Text, passwordField.Text, nombresField.Text, apellidoField.Text, (String)usuarioBox.SelectedItem, this.huella);
                            int hecho = user.agregarUsuario(user);
                            if (hecho == 0)
                            {
                                MessageBox.Show("Usuario registrado exitosamente.");
                                inicial.Visible = true;
                                this.Close();
                            }
                            else if (hecho == -1)
                            {
                                MessageBox.Show("El usuario especificado ya se encuentra registrado.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                            }
                            else
                            {
                                MessageBox.Show("Se produjo un error al registrar el usuario.");
                            }
                        }
                        else
                        {
                            Usuario user = new Usuario(nombreField.Text, passwordField.Text, nombresField.Text, apellidoField.Text, (String)usuarioBox.SelectedItem, null);
                            int hecho = user.agregarUsuarioSinHuella(user);
                            if (hecho == 0)
                            {
                                MessageBox.Show("Usuario registrado exitosamente.");
                                inicial.Visible = true;
                                this.Close();
                            }
                            else if (hecho == -1)
                            {
                                MessageBox.Show("El usuario especificado ya se encuentra registrado.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                            }
                            else
                            {
                                MessageBox.Show("Se produjo un error al registrar el usuario.");
                            }
                        }
                        
                    }
                    
                }
            }
            else
            {
                if (rol)
                {
                    obtenido.rol = (String)usuarioBox.SelectedItem;
                    if (obtenido.modificarRol(obtenido) == 0)
                    {
                        MessageBox.Show("Rol modificado exitosamente.");
                        inicial.Visible = true;
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Se produjo un error al modificar el rol.");
                    }
                }
                else
                {
                    
                   
                    if (camposVacios())
                    {
                        MessageBox.Show("Se requiere llenar todos los campos.");
                    }
                    else
                    {
                        if (verificarCampos()) {
                            MessageBox.Show("Llene correctamente todos los campos.");
                        } else
                        {
                            Usuario modificado = new Usuario(nombreField.Text, passwordField.Text, nombresField.Text, apellidoField.Text, (String)usuarioBox.SelectedItem, this.huella);
                            if (obtenido.modificarUsuario(modificado) == 0)
                            {
                                MessageBox.Show("Usuario modificado exitosamente.");
                                inicial.Visible = true;
                                this.Close();
                            }
                            else
                            {
                                MessageBox.Show("Se produjo un error al guardar los cambios.");
                            }
                        }
                        
                    }
                }
            }
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
        public Boolean camposVacios()
        {
            Boolean lleno = false;
            fieldList.Add(nombreField);
            fieldList.Add(passwordField);
            fieldList.Add(nombresField);
            fieldList.Add(apellidoField);
            foreach (TextBox singleItem in fieldList)
            {
                if (singleItem.Text.Trim().Equals(""))
                {
                    lleno = true;
                    singleItem.BackColor = Color.IndianRed;
                }
                else
                {
                    singleItem.BackColor = Color.White;
                }
            }
            return lleno;
        }
        private void LimpiarButton_Click(object sender, EventArgs e)
        {

            fieldList.Add(nombreField);
            fieldList.Add(passwordField);
            fieldList.Add(nombresField);
            fieldList.Add(apellidoField);

            foreach (TextBox singleItem in fieldList)
            {
                singleItem.Clear();
                singleItem.BackColor = Color.White;
            }
        }
        public Boolean verificarCampos()
        {
            Boolean correcto = false; 
            if((nombreField.Text.Length <8 && nombreField.Text.Length > 0) || nombreField.Text.Length > 12)
            {
                correcto = true;
                nombreField.BackColor = Color.LightBlue;
            }
            if (!validar.contrasenia(passwordField) || (passwordField.Text.Length > 15 || passwordField.Text.Length < 10))
            {
                correcto = true;
                passwordField.BackColor = Color.LightBlue;
            }
            return correcto;
        }
            private void CancelarButton_Click(object sender, EventArgs e)
        {
            inicial.Visible = true;
            this.Close();
        }

        private void LabelIngreso_Click(object sender, EventArgs e)
        {

        }

        private void NombreField_KeyUp(object sender, KeyEventArgs e)
        {

        }

        private void PasswordField_KeyUp(object sender, KeyEventArgs e)
        {

        }

        private void NombreField_Leave(object sender, EventArgs e)
        {
            if ((nombreField.Text.Length < 8 && nombreField.Text.Length > 0) || nombreField.Text.Length > 12)
            {
                ToolTip tt = new ToolTip();
                tt.IsBalloon = true;
                tt.Show("Ingrese un User ID entre 8 y 12 caracteres.", nombreField, 0, -40, VisibleTime);
            }
            if (string.IsNullOrWhiteSpace(nombreField.Text))
            {
                ToolTip tt = new ToolTip();
                tt.IsBalloon = true;
                tt.Show("No deje este campo vacío.", nombreField, 0, -40, VisibleTime);
            }
        }

        private void PasswordField_Leave(object sender, EventArgs e)
        {
            if ((passwordField.Text.Length > 0 && passwordField.Text.Length < 10) || passwordField.Text.Length > 15)
            {

                this.valido = false;
                ToolTip tt = new ToolTip();
                tt.IsBalloon = true;
                tt.Show("Ingrese una contraseña de entre 10 y 15 caracteres.", passwordField, 0, -40, VisibleTime);

            }
            if (string.IsNullOrWhiteSpace(passwordField.Text))
            {
                ToolTip tt = new ToolTip();
                tt.IsBalloon = true;
                tt.Show("No deje este campo vacío.", passwordField, 0, -40, VisibleTime);
            }
        }

        private void PasswordField_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void ApellidoField_Leave(object sender, EventArgs e)
        {
            if (apellidoField.Text.Length > 50)
            {
                ToolTip tt = new ToolTip();
                tt.IsBalloon = true;
                tt.Show("Ingrese un apellido no mayor a 50 caracteres.", apellidoField, 0, -40, VisibleTime);

            }
            if (string.IsNullOrWhiteSpace(apellidoField.Text))
            {
                ToolTip tt = new ToolTip();
                tt.IsBalloon = true;
                tt.Show("No deje este campo vacío.", apellidoField, 0, -40, VisibleTime);
            }
        }

        private void NombresField_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsLetter(e.KeyChar)) && (e.KeyChar != (char)Keys.Back) && (e.KeyChar != (char)Keys.Space))
            {
                e.Handled = true;
                return;
            }
        }

        private void NombreField_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar) || char.IsLetter(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                e.Handled = true;
                return;
            }
        }

        private void ApellidoField_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsLetter(e.KeyChar)) && (e.KeyChar != (char)Keys.Back) && (e.KeyChar != (char)Keys.Space))
            {
                e.Handled = true;
                return;
            }
        }

        private void NombreField_Enter(object sender, EventArgs e)
        {
            nombreField.BackColor = Color.White;

                
            
        }

        private void PasswordField_Enter(object sender, EventArgs e)
        {
            passwordField.BackColor = Color.White;
        }

        private void NombresField_Enter(object sender, EventArgs e)
        {
            nombresField.BackColor = Color.White;
        }

        private void ApellidoField_Enter(object sender, EventArgs e)
        {
            apellidoField.BackColor = Color.White;
        }

        private void NombresField_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(nombresField.Text))
            {
                ToolTip tt = new ToolTip();
                tt.IsBalloon = true;
                tt.Show("No deje este campo vacío.", nombresField, 0, -40, VisibleTime);
            }
        }

        private void HuellaButton_Click(object sender, EventArgs e)
        {
            new Huellas(this).Visible = true;
            this.Visible = false;
        }

        
    }
}
