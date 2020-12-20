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
    public partial class Inventario : Form
    {
        public Form inicial;
        public List<TextBox> fieldList = new List<TextBox>();
        public String codigo;
        public Boolean modificar;
        Producto producto = new Producto();
        public Inventario(Form interfazInicial)
        {
            InitializeComponent();
            this.inicial = interfazInicial;
            cargarProveedores();
            cargarCategorias();
        }
        public Inventario(Boolean modificar, Form interfaz, String codigo)
        {
            InitializeComponent();
            this.modificar = modificar;
            labelIngreso.Text = "Modificación de Productos";
            this.inicial = interfaz;
            this.codigo = codigo;
            modificarP();
        }
        public void modificarP()
        {
            cargarProveedores();
            cargarCategorias();
            this.producto = producto.obtenerProducto(this.codigo);
            codigoField.Text = producto.codigo;
            nombreField.Text = producto.nombre;
            disponiblesField.Text = Convert.ToString(producto.unidadesDisponibles);
            unitarioField.Text = Convert.ToString(producto.precioVentaUnitario);
            descuentoField.Text = Convert.ToString(producto.descuento);
            unidadField.Text = producto.unidadVenta;
            adquisicionField.Text = Convert.ToString(producto.precioAdquisicion);
            gananciaField.Text = Convert.ToString(producto.precioGananciaMinima);
            proveedorBox.SelectedValue = new Proveedor().obtenerNombreProveedor(producto.proveedorRUC);
            categoriaBox.SelectedValue = new Categoria().obtenerNombreCategoria(producto.categoriaID);
            minimoField.Text = Convert.ToString(producto.unidadesMinimas);
            nombreField.Enabled = false;
            codigoField.Enabled = false;
        }
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);

        private void Minimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
        private void cargarProveedores()
        {
            Proveedor proveedor = new Proveedor();
            DataTable proveedores = proveedor.todoProveedor();
            proveedorBox.DisplayMember = "proveedorNombre".TrimEnd();
            proveedorBox.ValueMember = "proveedorNombre".TrimEnd();
            proveedorBox.DataSource = proveedores;
        }
        private void cargarCategorias()
        {
            Categoria categoria = new Categoria();
            DataTable categorias = categoria.todaCategoria();
            categoriaBox.DisplayMember = "categoriaNombre".TrimEnd();
            categoriaBox.ValueMember = "categoriaNombre".TrimEnd();
            categoriaBox.DataSource = categorias;
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

        private void TextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void TextBox3_TextChanged(object sender, EventArgs e)
        {

        }
        private Boolean verificarCampos()
        {
            Boolean correcto = false;
            if (descuentoField.Text.Split(',').Length - 1 > 1)
            {
                descuentoField.BackColor = Color.LightBlue;
                correcto = true;
            }
            if (unitarioField.Text.Split(',').Length - 1 > 1)
            {
                unitarioField.BackColor = Color.LightBlue;
                correcto = true;
            }
            if (adquisicionField.Text.Split(',').Length - 1 > 1)
            {
                adquisicionField.BackColor = Color.LightBlue;
                correcto = true;
            }
            if (gananciaField.Text.Split(',').Length - 1 > 1)
            {
                gananciaField.BackColor = Color.LightBlue;
                correcto = true;
            }
            return correcto;
        }
        private void Button1_Click(object sender, EventArgs e)
        {
            if (modificar == false)
            {
                if (validarCampos())
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
                        if (Convert.ToDecimal(descuentoField.Text) == 100)
                        {
                            MessageBox.Show("Descuento máximo excedido.");
                        }
                        else
                        {
                            DateTime fecha = DateTime.Now;
                            int idCategoria = new Categoria().obtenerIDCategoria(categoriaBox.Text);
                            String rucProveedor = new Proveedor().obtenerRUCProveedor(proveedorBox.Text);
                            Producto producto = new Producto(codigoField.Text, nombreField.Text, Convert.ToInt32(disponiblesField.Text), Convert.ToDecimal(unitarioField.Text), Convert.ToDecimal(descuentoField.Text), unidadField.Text, 0, Convert.ToDecimal(adquisicionField.Text), fecha, Convert.ToDecimal(gananciaField.Text), rucProveedor, 1, idCategoria, Convert.ToInt32(minimoField.Text));
                            int hecho = producto.agregarProducto(producto);
                            if (hecho == 0)
                            {
                                MessageBox.Show("Producto registrado exitosamente.");
                                inicial.Visible = true;
                                this.Close();
                            }
                            else if (hecho == -1)
                            {
                                MessageBox.Show("El producto especificado ya se encuentra registrado.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                            }
                            else
                            {
                                MessageBox.Show("Se produjo un error al registrar el producto.");
                            }
                        }
                    }
                    
                    
                }
            }
            else
            {
                if (validarCampos())
                {
                    MessageBox.Show("Se requiere llenar todos los campos.");
                }
                else
                {
                    DateTime fecha = DateTime.Now;
                    int idCategoria = new Categoria().obtenerIDCategoria(categoriaBox.Text);
                    String rucProveedor = new Proveedor().obtenerRUCProveedor(proveedorBox.Text);
                    Producto producto = new Producto(codigoField.Text, nombreField.Text, Convert.ToInt32(disponiblesField.Text), Convert.ToDecimal(unitarioField.Text), Convert.ToDecimal(descuentoField.Text), unidadField.Text, 0, Convert.ToDecimal(adquisicionField.Text), fecha, Convert.ToDecimal(gananciaField.Text), rucProveedor, 1, idCategoria, Convert.ToInt32(minimoField.Text));
                    int hecho = producto.modificarProducto(producto);
                    if (hecho == 0)
                    {
                        MessageBox.Show("Producto modificado exitosamente.");
                        inicial.Visible = true;
                        this.Close();
                    }
                 
                    else
                    {
                        MessageBox.Show("Se produjo un error al modificar el producto.");
                    }
                }
            }
                
        }
        private Boolean validarCampos()
        {
            Boolean lleno = false;
            fieldList.Add(codigoField);
            fieldList.Add(nombreField);
            fieldList.Add(disponiblesField);
            fieldList.Add(unitarioField);
            fieldList.Add(descuentoField);
            fieldList.Add(adquisicionField);
            fieldList.Add(gananciaField);
            fieldList.Add(minimoField);
            if (!(proveedorBox.SelectedIndex >= 0))
            {
                MessageBox.Show("Seleccione un proveedor.");
                lleno = true;
            }
            if (!(categoriaBox.SelectedIndex >= 0))
            {
                MessageBox.Show("Seleccione una categoría.");
                lleno = true;
            }
            
                foreach (TextBox singleItem in fieldList)
                {
                    if (singleItem.Text.Equals(""))
                    {
                        lleno = true;
                        singleItem.BackColor = Color.IndianRed;
                    }

                }
                
            
            return lleno;
        }
        private void Button3_Click(object sender, EventArgs e)
        {
            
            inicial.Visible = true;
            this.Close();
        }
        
        private void Panel1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void LabelIngreso_Click(object sender, EventArgs e)
        {

        }

        private void CodigoField_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar) || char.IsLetter(e.KeyChar) || e.KeyChar.Equals('-')) && (e.KeyChar != (char)Keys.Back))
            {
                e.Handled = true;
                return;
            }
        }

        private void NombreField_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar) || char.IsLetter(e.KeyChar)) && (e.KeyChar != (char)Keys.Back && e.KeyChar != (char)Keys.Space))
            {
                e.Handled = true;
                return;
            }
        }

        private void DisponiblesField_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                e.Handled = true;
                return;
            }
        }

        private void UnitarioField_Leave(object sender, EventArgs e)
        {

        }

        private void UnitarioField_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar) || e.KeyChar.Equals(',')) && (e.KeyChar != (char)Keys.Back))
            {
                e.Handled = true;
                return;
            }
        }

        private void DescuentoField_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar) || e.KeyChar.Equals(',')) && (e.KeyChar != (char)Keys.Back))
            {
                e.Handled = true;
                return;
            }
            
        }

        private void UnidadField_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar) || char.IsLetter(e.KeyChar)) && (e.KeyChar != (char)Keys.Back && e.KeyChar != (char)Keys.Space))
            {
                e.Handled = true;
                return;
            }
        }

        private void AdquisicionField_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar) || e.KeyChar.Equals(',')) && (e.KeyChar != (char)Keys.Back))
            {
                e.Handled = true;
                return;
            }
        }

        private void GananciaField_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar) || e.KeyChar.Equals(',')) && (e.KeyChar != (char)Keys.Back))
            {
                e.Handled = true;
                return;
            }
        }

        private void MinimoField_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                e.Handled = true;
                return;
            }
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            if (modificar == false)
            {


                fieldList.Add(codigoField);
                fieldList.Add(nombreField);
                fieldList.Add(disponiblesField);
                fieldList.Add(unidadField);
                fieldList.Add(unitarioField);
                fieldList.Add(descuentoField);
                fieldList.Add(adquisicionField);
                fieldList.Add(gananciaField);
                fieldList.Add(minimoField);
                foreach (TextBox singleItem in fieldList)
                {
                    singleItem.Text = "";
                }
            }
            else
            {
                fieldList.Add(disponiblesField);
                fieldList.Add(unidadField);
                fieldList.Add(unitarioField);
                fieldList.Add(descuentoField);
                fieldList.Add(adquisicionField);
                fieldList.Add(gananciaField);
                fieldList.Add(minimoField);
                foreach (TextBox singleItem in fieldList)
                {
                    singleItem.Text = "";
                }
            }
        }

        private void Panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
