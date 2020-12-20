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
using sistema_de_facturacion.Principal;
using sistema_de_facturacion.Modelo;
using System.Text.RegularExpressions;
using System.Windows.Input;
using sistema_de_facturacion.Huella;

namespace sistema_de_facturacion.Clientes
{
    public partial class AgregarCliente : Form
    {
        public Form inicial;
        public List<TextBox> fieldList = new List<TextBox>();
        public Boolean modificar;
        public String identificacion;
        Validacion validar = new Validacion();
        Cliente modificarC= new Cliente();
        int VisibleTime = 2250;
        public byte[] huella;
        public AgregarCliente(Form interfazInicial)
        {
            InitializeComponent();
            this.inicial = interfazInicial;
            razonField.Enabled = false;
            siRadio.Checked = true;
            natural.Checked = true;
            activo.Checked = true;
            cedulaR.Checked = true;
            cedulaField.Enabled = true;
            pasaporteR.Enabled = true;
            pasaporteField.Enabled = false;
            rucR.Enabled = false;
            rucField.Enabled = false;
            inactivo.Enabled = false;
            huellaButton.Enabled = true;
        }
        public AgregarCliente(Boolean modificacion, Form ventana, String identificacion)
        {
            InitializeComponent();
            this.modificar = modificacion;
            this.inicial = ventana;
            this.identificacion = identificacion.TrimEnd();
            modificarF();
            //siRadio.Select();
        }
        public void modificarF()
        {
            
            Cliente existente = modificarC.obtenerCliente(identificacion);
            
            if (existente.tipo.TrimEnd().Equals("Natural"))
            {
                natural.Checked = true;
                razonField.Text = "";
                nombreField.Text = existente.nombre;
                apellidoField.Text = existente.apellido;
                if (validar.numeros2(existente.cRUC))
                {
                    cedulaR.Checked = true;
                    cedulaField.Text = existente.cRUC;
                }
                else
                {
                    pasaporteR.Checked = true;
                    pasaporteField.Text = existente.cRUC;
                }

                
            }
            else
            {
                rucField.Text = existente.cRUC;
                rucR.Checked = true;
                nombreField.Text = "";
                apellidoField.Text = "";
                juridica.Checked = true;
                razonField.Text = existente.nombre;
            }
            if (existente.huella == null)
            {
                noRadio.Checked = true;
            }
            else {
                siRadio.Checked = true;
            }
            telefonoField.Text = existente.telefono;
            direccionField.Text = existente.direccion;
            correoField.Text = existente.correo;
            ciudadField.Text = existente.ciudad;
            if (existente.baja.Equals("Inactivo"))
            {
                inactivo.Checked = true;
            }
            else
            {
                activo.Checked = true;
            }
            huellaButton.Enabled = false;
            cedulaR.Enabled = false;
            pasaporteField.Enabled = false;
            cedulaField.Enabled = false;
            rucR.Enabled = false;
            pasaporteR.Enabled = false;
            rucField.Enabled = false;
            razonField.Enabled = false;
            nombreField.Enabled = false;
            apellidoField.Enabled = false;
            natural.Enabled = false;
            juridica.Enabled = false;
            activo.Enabled = false;
            siRadio.Enabled = false;
            noRadio.Enabled = false;
            inactivo.Enabled = false;
            labelIngreso.Text = "Modificación de Clientes";
            registrarButton.Text = "Guardar Cambios";
            limpiarButton.Visible = false;

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

        private void Minimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void Panel1_Paint(object sender, PaintEventArgs e)
        {

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

        private void TableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void CancelarButton_Click(object sender, EventArgs e)
        {
            inicial.Visible = true;
            this.Close();
        }
        public Boolean verificarCampos()
        {
            Boolean correcto = false;
            if (natural.Checked)
            {
                if (cedulaR.Checked)
                {
                    if (!validar.VerificaCedula(cedulaField.Text) || cedulaField.Text.Length < 10)
                    {
                        correcto = true;
                        cedulaField.BackColor = Color.LightBlue;
                    }
                }
                if (pasaporteR.Checked) //Verificar Pasaporte
                {
                    if (!validar.letrasNumeros(pasaporteField))
                    {
                        correcto = true;
                        pasaporteField.BackColor = Color.LightBlue;
                    }
                }
                if (!validar.letras(nombreField))
                {
                    correcto = true;
                    nombreField.BackColor = Color.LightBlue;
                }
                
                if (apellidoField.Text.Length>0 && !validar.letras(apellidoField))
                {
                    correcto = true;
                    apellidoField.BackColor = Color.LightBlue;
                }
            }
            else if(juridica.Checked)
            {
                if (!validar.RucPersonaNatural(rucField.Text))
                {
                    correcto = true;
                    rucField.BackColor = Color.LightBlue;
                }
                if (!validar.letras(razonField)) 
                {
                    correcto =  true;
                    razonField.BackColor = Color.LightBlue;
                }
            }
            if (!validar.numeros(telefonoField))
            {
                correcto = true;
                telefonoField.BackColor = Color.LightBlue;
            }
            //-----Dirección-----
            if (!validar.correo(correoField))
            {
                correcto = true;
                correoField.BackColor = Color.LightBlue;
            }
            if (!validar.letras(ciudadField))
            {
                correcto = true;
                ciudadField.BackColor = Color.LightBlue;
            }
            return correcto;
        }
        public Boolean camposVacios()
        {
            if (natural.Checked)
            {
                if (cedulaR.Checked)
                {
                    fieldList.Add(cedulaField);
                }
                if(pasaporteR.Checked)
                {
                    fieldList.Add(pasaporteField);
                }
                fieldList.Add(nombreField);
            }else if (juridica.Checked)
            {
                fieldList.Add(rucField);
                fieldList.Add(razonField);

            }
            fieldList.Add(telefonoField);
            fieldList.Add(direccionField);
            fieldList.Add(correoField);
            fieldList.Add(ciudadField);
            Boolean lleno = false;
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

            
            if (modificar == false)
            {
                //Registro cliente
                
                if (camposVacios())
                {
                    MessageBox.Show("Se requiere llenar todos los campos.");
                    fieldList.Clear();
                }
                else
                {
                    if (verificarCampos())
                    {
                        MessageBox.Show("Llenar correctamente todos los campos.");
                    }
                    else
                    {

                        String nombre, estado, tipo;
                        String crp = "";
                        if (natural.Checked)
                        {
                            tipo = "Natural";
                            nombre = nombreField.Text;
                            if (cedulaR.Checked)
                            {
                                crp = cedulaField.Text;
                            }
                            else if (pasaporteR.Checked)
                            {
                                crp = pasaporteField.Text;
                            }
                        }
                        else
                        {
                            tipo = "Jurídica";
                            crp = rucField.Text;
                            nombre = razonField.Text;
                            apellidoField.Text = null;
                        }
                        if (activo.Checked)
                        {
                            estado = "Activo";
                        }
                        else
                        {
                            estado = "Inactivo";
                        }
                        if (siRadio.Checked)
                        {
                            //Setear valor a huella
                            new Huellas(this).Visible = true;
                            this.Visible = false;
                        }
                        else
                        {
                            this.huella = null;
                        }
                        //Verificar primero con regex antes de declarar el nuevo objeto cliente. Aquí mando if, invoco función.
                        Cliente client = new Cliente(crp, nombre, apellidoField.Text.TrimEnd(), telefonoField.Text.TrimEnd(), direccionField.Text.TrimEnd(), ciudadField.Text.TrimEnd(), correoField.Text.TrimEnd(), this.huella, tipo, estado);
                        
                        if (siRadio.Checked)
                        {
                            int hecho = client.agregarCliente(client);
                            if (hecho == 0)
                            {
                                MessageBox.Show("Cliente registrado con éxito.");
                                inicial.Visible = true;
                                this.Close();
                            }
                            else if (hecho == -1)
                            {
                                MessageBox.Show("El cliente especificado ya se encuentra registrado.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                            }
                            else
                            {
                                MessageBox.Show("Se produjo un error al registrar el cliente.");
                            }
                        }
                        else
                        {
                            int hecho = client.agregarClienteSinHuella(client);
                            if (hecho == 0)
                            {
                                MessageBox.Show("Cliente registrado con éxito.");
                                inicial.Visible = true;
                                this.Close();
                            }
                            else if (hecho == -1)
                            {
                                MessageBox.Show("El cliente especificado ya se encuentra registrado.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                            }
                            else
                            {
                                MessageBox.Show("Se produjo un error al registrar el cliente.");
                            }
                        }
                        
                    }
                }
            }
            else
            {
                //Guardo cliente modificado


                if (camposVacios())
                {
                    MessageBox.Show("Se requiere llenar todos los campos.");
                }
                else { 
                    String crp = "";
                    if (cedulaR.Checked)
                    {
                        crp = cedulaField.Text;
                    }else if (rucR.Checked)
                    {
                        crp = rucField.Text;
                    }else if (pasaporteR.Checked)
                    {
                        crp = pasaporteField.Text;
                    }
                    Cliente client = new Cliente(crp, nombreField.Text.TrimEnd(), apellidoField.Text.TrimEnd(), telefonoField.Text.TrimEnd(), direccionField.Text.TrimEnd(), ciudadField.Text.TrimEnd(), correoField.Text.TrimEnd(), huella, "NJ", "IA");
                    if (client.modificarCliente(client) == 0)
                    {
                        MessageBox.Show("Cliente modificado exitosamente.");
                        this.Close();
                        inicial.Visible = true;
                    }
                    else
                    {
                        MessageBox.Show("Se produjo un error al modificar el cliente.");
                    }


                }
            }
        }

        private void LimpiarButton_Click(object sender, EventArgs e)
        {
            //fieldList.Add(cedulaRUCField);
            if (natural.Checked)
            {
                fieldList.Add(nombreField);
                fieldList.Add(apellidoField);
                fieldList.Add(cedulaField);
                fieldList.Add(pasaporteField);
            }
            if (juridica.Checked)
            {
                fieldList.Add(razonField);
                fieldList.Add(rucField);
            }
            fieldList.Add(telefonoField);
            fieldList.Add(direccionField);
            fieldList.Add(correoField);
            fieldList.Add(ciudadField);
            foreach (TextBox singleItem in fieldList)
            {
                singleItem.Text = "";
            }
        }

        private void RadioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void Label5_Click(object sender, EventArgs e)
        {

        }

        private void TableLayoutPanel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Juridica_CheckedChanged(object sender, EventArgs e)
        {
            if (juridica.Checked)
            {
                nombreField.BackColor = Color.White;
                apellidoField.BackColor = Color.White;
                cedulaField.BackColor = Color.White;
                pasaporteField.BackColor = Color.White;
                cedulaField.Text = "";
                pasaporteField.Text = "";
                
            }

            cedulaR.Enabled = false;
            cedulaField.Enabled = false;
            pasaporteR.Enabled = false;
            pasaporteField.Enabled = false;
            rucR.Enabled = true;
            rucR.Checked = true;
            rucField.Enabled = true;
            nombreField.Enabled = false;
            apellidoField.Enabled = false;
            razonField.Enabled = true;
            razonField.Text = "";
        }

        private void AgregarCliente_Load(object sender, EventArgs e)
        {

        }

        private void Natural_CheckedChanged(object sender, EventArgs e)
        {
            if (natural.Checked)
            {
                razonField.BackColor = Color.White;
                rucField.BackColor = Color.White;
                cedulaR.Checked = true;
                rucField.Text = "";
            }
            pasaporteField.Enabled = false;
            cedulaR.Enabled = true;
            rucR.Enabled = false;
            cedulaField.Enabled = true;
            pasaporteR.Enabled = true;
            rucField.Enabled = false;
            nombreField.Enabled = true;
            apellidoField.Enabled = true;
            razonField.Enabled = false;
            nombreField.Text = "";
            apellidoField.Text = "";
        }

        private void LabelIngreso_Click(object sender, EventArgs e)
        {

        }

        private void Label2_Click(object sender, EventArgs e)
        {

        }

        private void TableLayoutPanel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void NoRadio_CheckedChanged(object sender, EventArgs e)
        {
            huellaButton.Enabled = false;

        }

        private void SiRadio_CheckedChanged(object sender, EventArgs e)
        {
            huellaButton.Enabled = true;
        }



        private void NombreField_KeyUp(object sender, KeyEventArgs e)
        {

            String sinEspacios = nombreField.Text;
            if ((nombreField.Text.Length - sinEspacios.Trim().Length) > 1)
            {

                ToolTip tt = new ToolTip();
                tt.IsBalloon = true;
                tt.Show("Ingrese sólo un espacio entre palabras.", nombreField, 0, -40, VisibleTime);
            }
        }

        private void ApellidoField_KeyUp(object sender, KeyEventArgs e)
        {

            String sinEspacios = apellidoField.Text;
            if ((apellidoField.Text.Length - sinEspacios.Trim().Length) > 1)
            {
                ToolTip tt = new ToolTip();
                tt.IsBalloon = true;
                tt.Show("Ingrese sólo un espacio entre palabras.", apellidoField, 0, -40, VisibleTime);
            }
        }

        private void RazonField_KeyUp(object sender, KeyEventArgs e)
        {

            String sinEspacios = razonField.Text;
            if ((razonField.Text.Length - sinEspacios.Trim().Length) > 1)
            {
                ToolTip tt = new ToolTip();
                tt.IsBalloon = true;
                tt.Show("Ingrese sólo un espacio entre palabras.", razonField, 0, -40, VisibleTime);
            }
        }

        private void TelefonoField_KeyUp(object sender, KeyEventArgs e)
        {

        }

        private void DireccionField_KeyUp(object sender, KeyEventArgs e)
        {
            String sinEspacios = direccionField.Text;
            if ((direccionField.Text.Length - sinEspacios.Trim().Length) > 1)
            {
                ToolTip tt = new ToolTip();
                tt.IsBalloon = true;
                tt.Show("Ingrese sólo un espacio entre palabras.", direccionField, 0, -40, VisibleTime);
            }
        }

        private void CiudadField_KeyUp(object sender, KeyEventArgs e)
        {
 
            
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
            if (nombreField.Text.Length > 0)
            {
                if (string.IsNullOrWhiteSpace(nombreField.Text.Substring(nombreField.Text.Length - 1)))
                {
                    ToolTip tt = new ToolTip();
                    tt.IsBalloon = true;
                    tt.Show("No deje un espacio al final de la cadena.", nombreField, 0, -40, VisibleTime);
                }
            }
            else
            {
                ToolTip tt = new ToolTip();
                tt.IsBalloon = true;
                tt.Show("No deje este campo vacío.", nombreField, 0, -40, VisibleTime);
            }
            
        }

        private void CiudadField_Leave(object sender, EventArgs e)
        {
            if (ciudadField.Text.Length > 0)
            {
                if (string.IsNullOrWhiteSpace(ciudadField.Text.Substring(ciudadField.Text.Length - 1)))
                {
                    ToolTip tt = new ToolTip();
                    tt.IsBalloon = true;
                    tt.Show("No deje un espacio al final de la cadena.", ciudadField, 0, -40, VisibleTime);
                }
            }
            else
            {
                ToolTip tt = new ToolTip();
                tt.IsBalloon = true;
                tt.Show("No deje este campo vacío.", ciudadField, 0, -40, VisibleTime);
            }
        }

        private void ApellidoField_Leave(object sender, EventArgs e)
        {
            if (apellidoField.Text.Length > 0)
            {
                if (string.IsNullOrWhiteSpace(apellidoField.Text.Substring(apellidoField.Text.Length - 1)))
                {
                    ToolTip tt = new ToolTip();
                    tt.IsBalloon = true;
                    tt.Show("No deje un espacio al final de la cadena.", apellidoField, 0, -40, VisibleTime);
                }
            }
            
        }

        private void RazonField_Leave(object sender, EventArgs e)
        {
            if (razonField.Text.Length > 0)
            {
                if (string.IsNullOrWhiteSpace(razonField.Text.Substring(razonField.Text.Length - 1)))
                {
                    ToolTip tt = new ToolTip();
                    tt.IsBalloon = true;
                    tt.Show("No deje un espacio al final de la cadena.", razonField, 0, -40, VisibleTime);
                }
            }
            else
            {
                ToolTip tt = new ToolTip();
                tt.IsBalloon = true;
                tt.Show("No deje este campo vacío.", razonField, 0, -40, VisibleTime);
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
            if (!validar.numeros(telefonoField))
            {
                ToolTip tt = new ToolTip();
                tt.IsBalloon = true;
                tt.Show("Ingrese únicamente letras.", telefonoField, 0, -40, VisibleTime);
                telefonoField.Text = "";
            }
        }

        private void DireccionField_Leave(object sender, EventArgs e)
        {
            if (direccionField.Text.Length > 0)
            {
                if (string.IsNullOrWhiteSpace(direccionField.Text.Substring(direccionField.Text.Length - 1)))
                {
                    ToolTip tt = new ToolTip();
                    tt.IsBalloon = true;
                    tt.Show("No deje un espacio al final de la cadena.", direccionField, 0, -40, VisibleTime);
                }
            }
            else
            {
                ToolTip tt = new ToolTip();
                tt.IsBalloon = true;
                tt.Show("No deje este campo vacío.", direccionField, 0, -40, VisibleTime);
            }
        }

        private void TelefonoField_Enter(object sender, EventArgs e)
        {
            telefonoField.BackColor = Color.White;
        }

        

        private void LabelCRP_Click(object sender, EventArgs e)
        {

        }

        private void CedulaR_CheckedChanged(object sender, EventArgs e)
        {
            pasaporteR.Checked = false;
            cedulaField.Enabled = true;
            pasaporteField.Enabled = false;
        }

        private void PasaporteR_CheckedChanged(object sender, EventArgs e)
        {
            cedulaR.Checked = false;
            pasaporteField.Enabled = true;
            cedulaField.Enabled = false;
        }

        private void CedulaField_KeyUp(object sender, KeyEventArgs e)
        {

            if (!validar.numeros(cedulaField))
            {
                ToolTip tt = new ToolTip();
                tt.IsBalloon = true;
                tt.Show("Ingrese únicamente números.", cedulaField, 0, -40, VisibleTime);
            }
        }

        private void RucField_KeyUp(object sender, KeyEventArgs e)
        {

            if (!validar.numeros(rucField))
            {
                ToolTip tt = new ToolTip();
                tt.IsBalloon = true;
                tt.Show("Ingrese únicamente números.", rucField, 0, -40, VisibleTime);
            }
        }

        private void PasaporteField_KeyUp(object sender, KeyEventArgs e)
        {

            if (!validar.letrasNumeros(pasaporteField))
            {
                ToolTip tt = new ToolTip();
                tt.IsBalloon = true;
                tt.Show("Ingrese únicamente caracteres alfanuméricos.", pasaporteField, 0, -40, VisibleTime);
            }
        }

        

       

        private void PasaporteField_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(pasaporteField.Text))
            {
                ToolTip tt = new ToolTip();
                tt.IsBalloon = true;
                tt.Show("No deje este campo vacío.", pasaporteField, 0, -40, VisibleTime);
            }
        }
        private void CedulaR_CheckedChanged_1(object sender, EventArgs e)
        {
            cedulaField.BackColor = Color.White;
            pasaporteField.Enabled = false;
            if (cedulaR.Checked)
            {
                cedulaField.Enabled = true;
            }
            if (!modificar)
            {
                

                pasaporteField.Text = "";
            }

        }
        private void PasaporteR_CheckedChanged_1(object sender, EventArgs e)
        {
            pasaporteField.BackColor = Color.White;
            pasaporteField.Enabled = true;
            cedulaField.Enabled = false;
            if (!modificar)
            {
                cedulaField.Text = "";
            }
        }
        private void CorreoField_KeyUp(object sender, KeyEventArgs e)
        {

        }

        private void CedulaField_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back)){
                e.Handled = true;
                return;
            }
        }

        private void CedulaField_Leave_1(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(cedulaField.Text))
            {
                ToolTip tt = new ToolTip();
                tt.IsBalloon = true;
                tt.Show("No deje este campo vacío.", cedulaField, 0, -40, VisibleTime);
            }
            if ((!validar.VerificaCedula(cedulaField.Text)&&cedulaField.Text.Length>0)|| (cedulaField.Text.Length<10 && cedulaField.Text.Length>0))
            {
                ToolTip tt = new ToolTip();
                tt.IsBalloon = true;
                tt.Show("Cédula Incorrecta.", cedulaField, 0, -40, VisibleTime);
            }
        }

        private void CedulaField_Enter(object sender, EventArgs e)
        {
            cedulaField.BackColor = Color.White;
        }

        private void RucField_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                e.Handled = true;
                return;
            }
        }

        private void RucField_Leave_1(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(rucField.Text))
            {
                ToolTip tt = new ToolTip();
                tt.IsBalloon = true;
                tt.Show("No deje este campo vacío.", rucField, 0, -40, VisibleTime);
            }
            if ((!validar.RucPersonaNatural(rucField.Text) && rucField.Text.Length>0) || (rucField.Text.Length < 13 && rucField.Text.Length>0))
            {
                ToolTip tt = new ToolTip();
                tt.IsBalloon = true;
                tt.Show("RUC Incorrecto", rucField, 0, -40, VisibleTime);
            }
        }

        private void PasaporteField_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar) || char.IsLetter(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
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

        private void ApellidoField_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsLetter(e.KeyChar)) && (e.KeyChar != (char)Keys.Back) && (e.KeyChar != (char)Keys.Space))
            {
                e.Handled = true;
                return;
            }
        }

        private void RazonField_KeyPress(object sender, KeyPressEventArgs e)
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

        private void CedulaField_KeyUp_1(object sender, KeyEventArgs e)
        {

        }

        private void RucField_KeyUp_1(object sender, KeyEventArgs e)
        {
            
        }

        private void RucField_Enter(object sender, EventArgs e)
        {
            rucField.BackColor = Color.White;
        }

        private void PasaporteField_Enter(object sender, EventArgs e)
        {
            pasaporteField.BackColor = Color.White;
        }

        private void NombreField_Enter(object sender, EventArgs e)
        {
            nombreField.BackColor = Color.White;
        }

        private void RazonField_Enter(object sender, EventArgs e)
        {
            razonField.BackColor = Color.White;
        }

        private void DireccionField_Enter(object sender, EventArgs e)
        {
            direccionField.BackColor = Color.White;
        }

        private void CorreoField_Enter(object sender, EventArgs e)
        {
            correoField.BackColor = Color.White;
        }

        private void CiudadField_Enter(object sender, EventArgs e)
        {
            ciudadField.BackColor = Color.White;
        }

        private void PasaporteField_Leave_1(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(pasaporteField.Text))
            {
                ToolTip tt = new ToolTip();
                tt.IsBalloon = true;
                tt.Show("No deje este campo vacío.", pasaporteField, 0, -40, VisibleTime);
            }
        }

        private void HuellaButton_Click(object sender, EventArgs e)
        {
            new Huellas(this).Visible = true;
        }

        private void CedulaField_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
