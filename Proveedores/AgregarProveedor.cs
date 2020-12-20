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

namespace sistema_de_facturacion.Proveedores
{
    public partial class AgregarProveedor : Form
    {
        public Form inicial;
        public List<TextBox> fieldList = new List<TextBox>();
        public Boolean modificacion;
        public String ruc;
        Validacion validar = new Validacion();
        Proveedor modificar = new Proveedor();
        int VisibleTime = 2250;
        public AgregarProveedor(Form interfazInicial)
        {
            InitializeComponent();
            this.inicial = interfazInicial;
            activo.Checked = true;
            inactivo.Enabled = false;
        }
        public AgregarProveedor(Boolean modificar, Form interfaz, String ruc)
        {
            InitializeComponent();
            this.modificacion = modificar;
            this.inicial = interfaz;
            this.ruc = ruc;
            modificarF();
        }
        public void modificarF()
        {
            Proveedor existente = modificar.obtenerProveedor(ruc);
            RUCField.Text = existente.ruc;
            nombreField.Text = existente.nombre;
            telefonoField.Text = existente.telefono;
            direccionField.Text = existente.direccion;
            ciudadField.Text = existente.ciudad;
            correoField.Text = existente.correo;
            contactoField.Text = existente.personaContacto;
            telefonoCField.Text = existente.numeroContacto;
            if (existente.baja == 1)
            {
                activo.Checked = true;
            }
            else
            {
                inactivo.Checked = true;
            }
            RUCField.Enabled = false;
            nombreField.Enabled = false;
            activo.Enabled = false;
            inactivo.Enabled = false;
            labelIngreso.Text = "Modificación de Proveedores";
            registrarButton.Text = "Guardar Cambios";
            limpiarButton.Visible = false;
        }
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);
        private void Minimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
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

        private void Cerrar_Click(object sender, EventArgs e)
        {
            inicial.Visible = true;
            this.Close();
        }
        public Boolean verificarCampos()
        {
            Boolean correcto = false;
            if (!validar.RucPersonaNatural(RUCField.Text) || RUCField.Text.Length<13)
            {
                correcto = true;
                RUCField.BackColor = Color.LightBlue;
            }
            if (!validar.letras(nombreField))
            {
                correcto = true;
                nombreField.BackColor = Color.LightBlue;
            }
            if (!validar.letrasEspacio(ciudadField))
            {
                correcto = true;
                ciudadField.BackColor = Color.LightBlue;
            }
            if (!validar.correo(correoField))
            {
                correcto = true;
                correoField.BackColor = Color.LightBlue;
            }
            if (!validar.letras(contactoField))
            {
                correcto = true;
                contactoField.BackColor = Color.LightBlue;
            }
            return correcto;
        }
        public Boolean camposVacios()
        {
            Boolean lleno = false;
            fieldList.Add(RUCField);
            fieldList.Add(nombreField);
            fieldList.Add(telefonoCField);
            fieldList.Add(telefonoField);
            fieldList.Add(direccionField);
            fieldList.Add(ciudadField);
            fieldList.Add(correoField);
            fieldList.Add(contactoField);
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
        private void RegistrarButton_Click(object sender, EventArgs e)
        {
            if (modificacion == false)
            {

                if (camposVacios())
                {
                    MessageBox.Show("Se requiere llenar todos los campos.");
                }
                else
                {
                    if (verificarCampos())
                    {
                    MessageBox.Show("Llene correctamente todos los campos.");
                    }
                    else
                    {


                        int estado = -1;
                        if (activo.Checked)
                        {
                            estado = 1;
                        }
                        else
                        {
                            estado = 0;
                        }
                        //Verificar primero con regex antes de declarar el nuevo objeto cliente.
                        Proveedor proveedor = new Proveedor(RUCField.Text, nombreField.Text, telefonoField.Text, direccionField.Text, ciudadField.Text, correoField.Text, contactoField.Text, telefonoCField.Text, estado);
                        int hecho = proveedor.agregarProveedor(proveedor);
                        if (hecho == 0)
                        {
                            MessageBox.Show("Proveedor registrado exitosamente.");
                            inicial.Visible = true;
                            this.Close();
                        }
                        else if (hecho == -1)
                        {
                            MessageBox.Show("El proveedor especificado ya se encuentra registrado.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                        }
                        else
                        {
                            MessageBox.Show("Se produjo un error al registrar el proveedor.");

                        }

                    }
                }
            }
            else
            {
                //Guardo proveedor modificado

                if (camposVacios())
                {
                    MessageBox.Show("Se requiere llenar todos los campos.");
                }
                else
                {
                    Proveedor proveedor = new Proveedor(RUCField.Text,nombreField.Text,telefonoField.Text,direccionField.Text,ciudadField.Text, correoField.Text, contactoField.Text,telefonoCField.Text,1);
                    if (proveedor.modificarProveedor(proveedor) == 0)
                    {
                        MessageBox.Show("Proveedor modificado exitosamente.");
                        inicial.Visible = true;
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Se produjo un error al modificar el proveedor.");
                    }
                }
            }
        }

        private void Panel1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void LimpiarButton_Click(object sender, EventArgs e)
        {
            fieldList.Add(RUCField);
            fieldList.Add(nombreField);
            fieldList.Add(telefonoField);
            fieldList.Add(direccionField);
            fieldList.Add(ciudadField);
            fieldList.Add(correoField);
            fieldList.Add(contactoField);
            fieldList.Add(telefonoCField);
            foreach (TextBox singleItem in fieldList)
            {
                singleItem.Text = "";
            }
        }

        private void CancelarButton_Click(object sender, EventArgs e)
        {
            inicial.Visible = true;
            this.Close();
        }

        private void RUCField_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                e.Handled = true;
                return;
            }
        }

        private void NombreField_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsLetter(e.KeyChar)) && (e.KeyChar != (char)Keys.Back) && (e.KeyChar != (char)Keys.Space))
            {
                e.Handled = true;
                return;
            }
        }

        private void TelefonoField_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                e.Handled = true;
                return;
            }
        }

        private void CiudadField_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsLetter(e.KeyChar)) && (e.KeyChar != (char)Keys.Back) && (e.KeyChar != (char)Keys.Space))
            {
                e.Handled = true;
                return;
            }
        }

        private void ContactoField_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsLetter(e.KeyChar)) && (e.KeyChar != (char)Keys.Back) && (e.KeyChar != (char)Keys.Space))
            {
                e.Handled = true;
                return;
            }
        }

        private void TelefonoCField_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                e.Handled = true;
                return;
            }
        }

        private void RUCField_Enter(object sender, EventArgs e)
        {
            RUCField.BackColor = Color.White;
        }

        private void NombreField_Enter(object sender, EventArgs e)
        {
            nombreField.BackColor = Color.White;
        }

        private void TelefonoField_Enter(object sender, EventArgs e)
        {
            telefonoField.BackColor = Color.White;
        }

        private void DireccionField_Enter(object sender, EventArgs e)
        {
            direccionField.BackColor = Color.White;
        }

        private void CiudadField_Enter(object sender, EventArgs e)
        {
            ciudadField.BackColor = Color.White;
        }

        private void CorreoField_FontChanged(object sender, EventArgs e)
        {

        }

        private void CorreoField_Enter(object sender, EventArgs e)
        {
            correoField.BackColor = Color.White;
        }

        private void ContactoField_Enter(object sender, EventArgs e)
        {
            contactoField.BackColor = Color.White;
        }

        private void TelefonoCField_Enter(object sender, EventArgs e)
        {
            telefonoCField.BackColor = Color.White;
        }

        private void RUCField_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(RUCField.Text))
            {
                ToolTip tt = new ToolTip();
                tt.IsBalloon = true;
                tt.Show("No deje este campo vacío.", RUCField, 0, -40, VisibleTime);
            }
            if ((!validar.RucPersonaNatural(RUCField.Text)&&RUCField.Text.Length>0) || (RUCField.Text.Length < 13 && RUCField.Text.Length > 0))
            {
                ToolTip tt = new ToolTip();
                tt.IsBalloon = true;
                tt.Show("RUC Incorrecto", RUCField, 0, -40, VisibleTime);
            }
        }

        private void CorreoField_Leave(object sender, EventArgs e)
        {
            if (!validar.correo(correoField))
            {
                ToolTip tt = new ToolTip();
                tt.IsBalloon = true;
                tt.Show("Correo electrónico incorrecto", correoField, 0, -40, VisibleTime);
            }
        }

        private void NombreField_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(nombreField.Text))
            {
                ToolTip tt = new ToolTip();
                tt.IsBalloon = true;
                tt.Show("No deje este campo vacío.", nombreField, 0, -40, VisibleTime);
            }
        }

        private void TelefonoField_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(telefonoField.Text))
            {
                ToolTip tt = new ToolTip();
                tt.IsBalloon = true;
                tt.Show("No deje este campo vacío.", telefonoField, 0, -40, VisibleTime);
            }
        }

        private void DireccionField_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(direccionField.Text))
            {
                ToolTip tt = new ToolTip();
                tt.IsBalloon = true;
                tt.Show("No deje este campo vacío.", direccionField, 0, -40, VisibleTime);
            }
        }

        private void CiudadField_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(ciudadField.Text))
            {
                ToolTip tt = new ToolTip();
                tt.IsBalloon = true;
                tt.Show("No deje este campo vacío.", ciudadField, 0, -40, VisibleTime);
            }
        }

        private void ContactoField_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(contactoField.Text))
            {
                ToolTip tt = new ToolTip();
                tt.IsBalloon = true;
                tt.Show("No deje este campo vacío.", contactoField, 0, -40, VisibleTime);
            }
        }

        private void TelefonoCField_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(telefonoCField.Text))
            {
                ToolTip tt = new ToolTip();
                tt.IsBalloon = true;
                tt.Show("No deje este campo vacío.", telefonoCField, 0, -40, VisibleTime);
            }
        }
    }
}
