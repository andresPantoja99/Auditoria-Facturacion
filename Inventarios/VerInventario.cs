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

namespace sistema_de_facturacion.Inventarios
{
    public partial class VerInventario : Form
    {
        public Form inicial;
        public String tipo;
        public VerInventario(String type, Form interfazInicial)
        {
            InitializeComponent();
            this.inicial = interfazInicial;
            this.tipo = type;
            labelAdvertencia.Visible = false;
            parametroBox.SelectedIndex = 0;
            actualizarTabla();
            if (type.Equals("consultar"))
            {
                labelIngreso.Text = "Búsqueda de Productos";
                accionButton.Visible = false;
            }
            if (type.Equals("modificar"))
            {
                labelIngreso.Text = "Modificación de Productos";
                accionButton.Text = "Modificar datos del producto";
            }
            if (type.Equals("eliminar"))
            {

                labelIngreso.Text = "Cambio de Estado de Productos";
                accionButton.Text = "Cambiar estado de producto seleccionado";
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

        private void Button2_Click(object sender, EventArgs e)
        {

        }

        private void CerrarButton_Click(object sender, EventArgs e)
        {
            inicial.Visible = true;
            this.Close();
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

        private void MinimizarButton_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void RegresarButton_Click(object sender, EventArgs e)
        {
            inicial.Visible = true;
            this.Close();
        }

        private void ParametroField_KeyPress(object sender, KeyPressEventArgs e)
        {
            
        }

        private void ParametroField_KeyUp(object sender, KeyEventArgs e)
        {
            if (parametroBox.Text.Length > 0)
            {
                DataTable aux = new Producto().buscarProducto(parametroBox.SelectedIndex, parametroField.Text);
                ChangeColumnDataType(aux, "Estado", typeof(String));
                productosGrid.DataSource = aux;
                for (int i = 0; i < productosGrid.Rows.Count; i++)
                {
                    if ((String)productosGrid.Rows[i].Cells[11].Value == "1")
                    {
                        productosGrid.Rows[i].Cells[11].Value = "Activo";
                    }
                    else
                    {
                        productosGrid.Rows[i].Cells[11].Value = "Inactivo";
                    }

                }
            }
            else
            {
                MessageBox.Show("Elija un parámetro.");
                parametroField.Clear();
            }
        }
        public static bool ChangeColumnDataType(DataTable table, string columnname, Type newtype)
        {
            if (table.Columns.Contains(columnname) == false)
                return false;

            DataColumn column = table.Columns[columnname];
            if (column.DataType == newtype)
                return true;

            try
            {
                DataColumn newcolumn = new DataColumn("temporary", newtype);
                table.Columns.Add(newcolumn);
                foreach (DataRow row in table.Rows)
                {
                    try
                    {
                        row["temporary"] = Convert.ChangeType(row[columnname], newtype);
                    }
                    catch
                    {
                    }
                }
                table.Columns.Remove(columnname);
                newcolumn.ColumnName = columnname;
            }
            catch (Exception)
            {
                return false;
            }

            return true;
        }
        private void Panel1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void ParametroField_KeyUp_1(object sender, KeyEventArgs e)
        {
            if (parametroBox.Text.Length > 0)
            {
                labelAdvertencia.Visible = false;
                productosGrid.DataSource = new Producto().buscarProducto(parametroBox.SelectedIndex, parametroField.Text);
            }
            else
            {
                labelAdvertencia.Visible = true;
                parametroField.Clear();
            }
        }
        public void actualizarTabla()
        {
            DataTable aux = new Producto().buscarProducto(1, "");
            ChangeColumnDataType(aux, "Estado", typeof(String));
            productosGrid.DataSource = aux;
            for (int i = 0; i < productosGrid.Rows.Count; i++)
            {
                if ((String)productosGrid.Rows[i].Cells[13].Value == "1")
                {
                    productosGrid.Rows[i].Cells[13].Value = "Activo";
                }
                else
                {
                    productosGrid.Rows[i].Cells[13].Value = "Inactivo";
                }

            }
        }
        private void AccionButton_Click(object sender, EventArgs e)
        {
            //if (productosGrid.SelectedRows.Count > 0 && tipo.Equals("agregar"))
            //{
            //    string codigo = productosGrid.SelectedRows[0].Cells[0].Value.ToString();
            //    new Inventario(true, inicial, codigo).Visible = true;
            //    this.Visible = false;
            //}
            if (productosGrid.SelectedRows.Count > 0 && tipo.Equals("modificar"))
            {
                string codigo = productosGrid.SelectedRows[0].Cells[0].Value.ToString();
                new Inventario(true, inicial, codigo).Visible = true;
                this.Visible = false;
            }
            if (productosGrid.SelectedRows.Count > 0 && tipo.Equals("eliminar"))
            {
                string codigo = productosGrid.SelectedRows[0].Cells[0].Value.ToString();
                string estado = productosGrid.SelectedRows[0].Cells[13].Value.ToString().TrimEnd();
                if (estado.Equals("Activo"))
                {
                    if (new Producto().darDeBajaProducto(codigo) == 0)
                    {
                        MessageBox.Show("Estado del producto cambiado exitosamente.");
                        actualizarTabla();

                    }
                    else
                    {
                        MessageBox.Show("Error al cambiar el estado del producto.");
                    }
                }
                else
                {
                    if (new Producto().darDeAltaProducto(codigo) == 0)
                    {
                        MessageBox.Show("Estado del producto cambiado exitosamente.");
                        actualizarTabla();
                    }
                    else
                    {
                        MessageBox.Show("Error al cambiar el estado del producto.");
                    }
                }

            }
        }

        private void ParametroBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (parametroBox.SelectedIndex > 1)
            {
                productosGrid.DataSource = new Producto().segmentarProductos(parametroBox.SelectedIndex - 2);
                parametroField.Enabled = false;
            }
            else
            {
                parametroField.Enabled = true;
            }
        }
    }
}
