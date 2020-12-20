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

namespace sistema_de_facturacion.Facturacion
{
    public partial class VerFactura : Form
    {
        public Form inicial;
        String revisar;
        Boolean anular;
        public VerFactura(Form interfazInicial)
        {
            InitializeComponent();
            this.inicial = interfazInicial;
            //verButton.Visible = false;
        }
        public VerFactura(String modificar,Form interfazInicial)
        {
            InitializeComponent();
            this.inicial = interfazInicial;
            this.accionButton.Text = "Revisar factura seleccionada";
            labelIngreso.Text = "Revisión de Facturas";
            this.revisar = modificar;
            parametroBox.SelectedIndex = 0;
        }
        public VerFactura(Boolean anular, Form interfazInicial)
        {
            InitializeComponent();
            this.inicial = interfazInicial;
            this.accionButton.Text = "Anular factura seleccionada";
            this.anular = anular;
            labelIngreso.Text = "Anulación de Facturas";
            parametroBox.SelectedIndex = 0;
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

        private void VerButton_Click(object sender, EventArgs e)
        {

        }

        private void RegresarButton_Click(object sender, EventArgs e)
        {
            inicial.Visible = true;
            this.Close();
        }

        private void AccionButton_Click(object sender, EventArgs e)
        {
            if ((this.revisar!=null) && facturasGrid.SelectedRows.Count>0)
            {
                int codigoFactura = (int)facturasGrid.SelectedRows[0].Cells[0].Value;
                String idCliente = facturasGrid.SelectedRows[0].Cells[1].Value.ToString();
                Cliente obtenido = new Cliente().obtenerCliente(idCliente);
                Factura obtenida = new Factura().obtenerFactura(codigoFactura);
                new Facturas(this, obtenido, obtenida).Visible = true ;
                this.Visible = false;
            }else if ((this.revisar != null) && facturasGrid.SelectedRows.Count <= 0)
            {
                MessageBox.Show("Seleccione una factura para revisar");
            }
            if (this.anular && facturasGrid.SelectedRows.Count > 0)
            {
                int codigoFactura = (int)facturasGrid.SelectedRows[0].Cells[0].Value;
                if (MessageBox.Show("¿Está seguro que desea anular la factura seleccionada?", "Advertencia", MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    if(new Factura().anularFactura(codigoFactura) == 1)
                    {
                        MessageBox.Show("Factura anulada con éxito");
                        cargarTabla();
                    }
                    else
                    {
                        MessageBox.Show("Ocurrió un error al intentar anular la factura.");
                    }
                }
            }else if (this.anular && facturasGrid.SelectedRows.Count <= 0)
            {
                MessageBox.Show("Seleccione una factura para anular");
            }
        }

        private void ParametroField_KeyUp(object sender, KeyEventArgs e)
        {
            
        }
        private void cargarTabla()
        {
            if (parametroBox.SelectedIndex == 0)
            {
                facturasGrid.DataSource = new Factura().buscarFacturaCliente(parametroField.Text);

            }
            else
            {
                if (parametroField.Text.Length > 0)
                {
                    facturasGrid.DataSource = new Factura().buscarFacturaCodigo(Convert.ToInt32(parametroField.Text));
                }

            }
        }
        private void BuscarButton_Click(object sender, EventArgs e)
        {
            if (parametroField.Text.Trim().Equals("") && parametroBox.SelectedIndex==0)
            {
                MessageBox.Show("Ingrese la identificación del cliente");
            }else if(parametroField.Text.Trim().Equals("") && parametroBox.SelectedIndex == 1)
            {
                MessageBox.Show("Ingrese un número de factura");
            }
            else
            {
                if (parametroBox.SelectedIndex == 0)
                {
                    facturasGrid.DataSource = new Factura().buscarFacturaCliente(parametroField.Text);
                    if (facturasGrid.Rows.Count == 0)
                    {
                        MessageBox.Show("Cliente no registrado en el sistema");
                    }
                }
                else
                {
                    if (parametroField.Text.Length > 0)
                    {
                        facturasGrid.DataSource = new Factura().buscarFacturaCodigo(Convert.ToInt32(parametroField.Text));
                        if (facturasGrid.Rows.Count == 0)
                        {
                            MessageBox.Show("Factura no encontrada en el sistema");
                        }
                    }

                }
            }
            
        }

        private void ParametroField_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back) && parametroBox.SelectedIndex==1)
            {
                e.Handled = true;
                return;
            }
            if (!(char.IsNumber(e.KeyChar) || char.IsLetter(e.KeyChar)) && (e.KeyChar != (char)Keys.Back) && parametroBox.SelectedIndex ==0)
            {
                e.Handled = true;
                return;
            }
        }

        private void ParametroBox_TextChanged(object sender, EventArgs e)
        {
            parametroField.Text = "";
        }

        private void Panel1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
    }
}
