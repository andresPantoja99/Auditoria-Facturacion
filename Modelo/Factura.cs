using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sistema_de_facturacion.Modelo
{
    public class Factura
    {
        public int codigo { get; set; }
        public String rucCICliente { get; set; }
        public DateTime fecha { get; set; }
        public String vendedor { get; set; }
        public String formaPago { get; set; }

        public Decimal subTotal { get; set; }
        public Decimal descuento { get; set; }
        public Decimal subTotalNeto { get; set; }
        public Decimal iva { get; set; }
        public Decimal total { get; set; }
        public int anulada { get; set; }
        ConexionDB conexion = new ConexionDB();

        public Factura(int codigo, string rucCICliente, DateTime fecha, string vendedor, string formaPago, decimal subTotal, decimal descuento, decimal subTotalNeto, decimal iva, decimal total, int anulada)
        {
            this.codigo = codigo;
            this.rucCICliente = rucCICliente;
            this.fecha = fecha;
            this.vendedor = vendedor;
            this.formaPago = formaPago;
            this.subTotal = subTotal;
            this.descuento = descuento;
            this.subTotalNeto = subTotalNeto;
            this.iva = iva;
            this.total = total;
            this.anulada = anulada;
        }

        public Factura()
        {
        }
        public Factura obtenerFactura(int cadena)
        {

            conexion.abrirConexion();
            SqlCommand cmd = new SqlCommand("uspBuscarFactura", conexion.obtenerConexion());
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@facturaId", SqlDbType.Int).Value = cadena;
            SqlDataReader reader = cmd.ExecuteReader();
            if (reader.HasRows)
            {
                int codigoFactura = 0;
                String ciCliente = "";
                DateTime fecha = DateTime.Now;
                String vendedor = "";
                String formaPago = "";
                Decimal subtotal = 0;
                Decimal descuento = 0;
                Decimal subtotalNeto = 0;
                Decimal iva = 0;
                Decimal total = 0;
                while (reader.Read())
                {
                    codigoFactura = reader.GetInt32(0);
                    ciCliente = reader.GetString(1);
                    fecha = reader.GetDateTime(2);
                    vendedor = reader.GetString(3);
                    formaPago = reader.GetString(4);
                    subtotal = reader.GetDecimal(5);
                    descuento = reader.GetDecimal(6);
                    subtotalNeto = reader.GetDecimal(7);
                    iva = reader.GetDecimal(8);
                    total = reader.GetDecimal(9);
                }
                Factura obtenida = new Factura(codigoFactura, ciCliente, fecha, vendedor, formaPago, subtotal, descuento, subtotalNeto, iva, total, 1);
                conexion.cerrarConexion();
                return obtenida;
            }
            conexion.cerrarConexion();
            return null;
        }
        public int agregarFactura(Factura factura)
        {
            conexion.abrirConexion();
            SqlCommand cmd = new SqlCommand("uspRegistrarFactura", conexion.obtenerConexion());
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@clienteRucCi", SqlDbType.VarChar).Value = factura.rucCICliente;
            cmd.Parameters.Add("@vendedor", SqlDbType.VarChar).Value = factura.vendedor;
            cmd.Parameters.Add("@formaPago", SqlDbType.VarChar).Value = factura.formaPago;
            cmd.Parameters.Add("@subtotal", SqlDbType.Decimal).Value = factura.subTotal;
            cmd.Parameters.Add("@descuentoGlobal", SqlDbType.Decimal).Value = factura.descuento;
            cmd.Parameters.Add("@subtotalNeto", SqlDbType.Decimal).Value = factura.subTotalNeto;
            cmd.Parameters.Add("@total", SqlDbType.Decimal).Value = factura.total;
            SqlParameter retval = cmd.Parameters.Add("@retorno", SqlDbType.VarChar);
            retval.Direction = ParameterDirection.ReturnValue;
            cmd.ExecuteNonQuery();
            int retorno = (int)cmd.Parameters["@retorno"].Value;
            conexion.cerrarConexion();
            return retorno;
        }
        public int maxIdFactura()
        {
            int valor = 0;
            DataTable existente = buscarFacturaCodigo(1);
            conexion.abrirConexion();
            SqlCommand cmd = new SqlCommand("uspMaxIdFactura", conexion.obtenerConexion());
            cmd.CommandType = CommandType.StoredProcedure;
            SqlDataReader reader = cmd.ExecuteReader();
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    
                    valor = Convert.ToInt32(reader.GetValue(0));
                    if(valor == 1 && existente.Rows.Count == 0)
                    {
                        valor = 1;
                    }
                    else if(valor == 1 && existente.Rows.Count>0)
                    {
                        valor = 2;
                    }
                    else {
                        valor = valor+1;
                    }
                }

            }
            conexion.cerrarConexion();
            return valor;
        }
        public DataTable buscarFacturaCodigo(int codigo)
        {
            DataTable dtClientes = new DataTable();
            conexion.abrirConexion();
            SqlCommand cmd = new SqlCommand("uspBuscarFactura", conexion.obtenerConexion());
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@facturaId", SqlDbType.Int).Value = codigo;
            SqlDataReader reader = cmd.ExecuteReader();
            dtClientes.Load(reader);
            dtClientes.Columns[0].ColumnName = "Número de Factura";
            dtClientes.Columns[1].ColumnName = "ID Cliente";
            dtClientes.Columns[2].ColumnName = "Fecha";
            dtClientes.Columns[3].ColumnName = "Vendedor";
            dtClientes.Columns[4].ColumnName = "Forma de Pago";
            dtClientes.Columns[5].ColumnName = "Subtotal";
            dtClientes.Columns[6].ColumnName = "Descuento";
            dtClientes.Columns[7].ColumnName = "Subtotal Neto";
            dtClientes.Columns[8].ColumnName = "IVA";
            dtClientes.Columns[9].ColumnName = "Total";
            conexion.cerrarConexion();
            return dtClientes;
        }
        public DataTable buscarFacturaCliente(String id)
        {
            DataTable dtClientes = new DataTable();
            conexion.abrirConexion();
            SqlCommand cmd = new SqlCommand("uspHisFacturasCliente", conexion.obtenerConexion());
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@clienteRucCI", SqlDbType.VarChar).Value = id;
            SqlDataReader reader = cmd.ExecuteReader();
            dtClientes.Load(reader);
            dtClientes.Columns[0].ColumnName = "Número de Factura";
            dtClientes.Columns[1].ColumnName = "ID Cliente";
            dtClientes.Columns[2].ColumnName = "Fecha";
            dtClientes.Columns[3].ColumnName = "Vendedor";
            dtClientes.Columns[4].ColumnName = "Forma de Pago";
            dtClientes.Columns[5].ColumnName = "Subtotal";
            dtClientes.Columns[6].ColumnName = "Descuento";
            dtClientes.Columns[7].ColumnName = "Subtotal Neto";
            dtClientes.Columns[8].ColumnName = "Iva";
            dtClientes.Columns[9].ColumnName = "Total";
            conexion.cerrarConexion();
            return dtClientes;
        }
        public DataTable obtenerDetalle(int codigoFactura)
        {
            DataTable dtDetalle = new DataTable();
            conexion.abrirConexion();
            SqlCommand cmd = new SqlCommand("uspObtenerDetalleFactura", conexion.obtenerConexion());
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@facturaId", SqlDbType.Int).Value = codigoFactura;
            SqlDataReader reader = cmd.ExecuteReader();
            dtDetalle.Load(reader);
            dtDetalle.Columns[0].ColumnName = "Cantidad";
            dtDetalle.Columns[1].ColumnName = "Código";
            dtDetalle.Columns[2].ColumnName = "Detalle";
            dtDetalle.Columns[3].ColumnName = "Desc(%)";
            dtDetalle.Columns[4].ColumnName = "V. Unit.";
            dtDetalle.Columns[5].ColumnName = "V. Total";
            conexion.cerrarConexion();
            return dtDetalle;
        }
        public int anularFactura(int codigoFactura)
        {
            conexion.abrirConexion();
            SqlCommand cmd = new SqlCommand("uspAnularFacturas ", conexion.obtenerConexion());
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@facturaId", SqlDbType.Int).Value = codigoFactura;
            SqlParameter retval = cmd.Parameters.Add("@retorno", SqlDbType.VarChar);
            retval.Direction = ParameterDirection.ReturnValue;
            cmd.ExecuteNonQuery();
            int retorno = (int)cmd.Parameters["@retorno"].Value;
            conexion.cerrarConexion();
            return retorno;
        }
    }
}
