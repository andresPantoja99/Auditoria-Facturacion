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

namespace sistema_de_facturacion.Estimados
{
    public partial class VerProforma : Form
    {
        public Form inicial;
        String revisar;
        Boolean anular;
        public VerProforma(Form interfazInicial)
        {
            InitializeComponent();
            this.inicial = interfazInicial;
        }
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);
        public VerProforma(String modificar, Form interfazInicial)
        {
            InitializeComponent();
            this.inicial = interfazInicial;
            this.accionButton.Text = "Revisar proforma seleccionada";
            labelIngreso.Text = "Búsqueda de Proformas";
            this.revisar = modificar;
            parametroBox.SelectedIndex = 0;
        }
        public VerProforma(Boolean anular, Form interfazInicial)
        {
            InitializeComponent();
            this.inicial = interfazInicial;
            this.accionButton.Text = "Anular proforma seleccionada";
            this.anular = anular;
            labelIngreso.Text = "Anulación de Proformas";
            parametroBox.SelectedIndex = 0;
        }
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

        private void RegresarButton_Click(object sender, EventArgs e)
        {
            inicial.Visible = true;
            this.Close();
        }

        private void LabelIngreso_Click(object sender, EventArgs e)
        {

        }

        private void ParametroField_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                e.Handled = true;
                return;
            }
        }

        private void AccionButton_Click(object sender, EventArgs e)
        {
            if ((this.revisar != null) && proformasGrid.SelectedRows.Count > 0)
            {
                int codigoProforma = (int)proformasGrid.SelectedRows[0].Cells[0].Value;
                String idCliente = proformasGrid.SelectedRows[0].Cells[1].Value.ToString();
                Cliente obtenido = new Cliente().obtenerCliente(idCliente);
                Proforma obtenida = new Proforma().obtenerProforma(codigoProforma);
                new Proformas(this, obtenido, obtenida).Visible = true;
                this.Visible = false;
            }
            if (this.anular && proformasGrid.SelectedRows.Count > 0)
            {
                int codigoFactura = (int)proformasGrid.SelectedRows[0].Cells[0].Value;
                if (MessageBox.Show("¿Está seguro que desea anular la proforma seleccionada?", "Cancelar", MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    if (new Factura().anularFactura(codigoFactura) == 1)
                    {
                        MessageBox.Show("Factura anulada con éxito");
                        cargarTabla();
                    }
                    else
                    {
                        MessageBox.Show("Ocurrió un error al intentar anular la factura.");
                    }
                }
            }
        }
        private void cargarTabla()
        {
            if (parametroBox.SelectedIndex == 0)
            {
                proformasGrid.DataSource = new Proforma().buscarProformaCliente(parametroField.Text);

            }
            else
            {
                if (parametroField.Text.Length > 0)
                {
                    proformasGrid.DataSource = new Proforma().buscarProformaCodigo(Convert.ToInt32(parametroField.Text));
                }

            }
        }

        private void BuscarButton_Click(object sender, EventArgs e)
        {
            if (parametroBox.SelectedIndex == 0)
            {
                proformasGrid.DataSource = new Proforma().buscarProformaCliente(parametroField.Text);
                if (proformasGrid.Rows.Count == 0)
                {
                    MessageBox.Show("Cliente no registrado en el sistema");
                }
            }
            else
            {
                if (parametroField.Text.Length > 0)
                {
                    proformasGrid.DataSource = new Proforma().buscarProformaCodigo(Convert.ToInt32(parametroField.Text));
                    if (proformasGrid.Rows.Count == 0)
                    {
                        MessageBox.Show("Proforma no encontrada en el sistema");
                    }
                }

            }
        }
    }
}
