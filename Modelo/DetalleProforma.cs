using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sistema_de_facturacion.Modelo
{
    class DetalleProforma
    {
        public int codigoFactura { get; set; }
        public int cantidad { get; set; }
        public String codigoProducto { get; set; }
        public String nombreProducto { get; set; }
        public Decimal descuento { get; set; }
        public Decimal valorUnitario { get; set; }
        public Decimal valorTotal { get; set; }
        ConexionDB conexion = new ConexionDB();
        public DetalleProforma(int codigoFactura, int cantidad, string codigoProducto, string nombreProducto, decimal descuento, decimal valorUnitario, decimal valorTotal)
        {
            this.codigoFactura = codigoFactura;
            this.cantidad = cantidad;
            this.codigoProducto = codigoProducto;
            this.nombreProducto = nombreProducto;
            this.descuento = descuento;
            this.valorUnitario = valorUnitario;
            this.valorTotal = valorTotal;
        }
        public DetalleProforma()
        {

        }
        public int insertarProductoPrecompra(DetalleProforma df)
        {
            int retorno = -1;
            conexion.abrirConexion();
            SqlCommand cmd = new SqlCommand("uspInsertarProductoAPrecompraProforma", conexion.obtenerConexion());
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@facturaCodigo", SqlDbType.Int).Value = df.codigoFactura;
            cmd.Parameters.Add("@productoCodigo", SqlDbType.VarChar).Value = df.codigoProducto;
            cmd.Parameters.Add("@cantidad", SqlDbType.Int).Value = df.cantidad;
            cmd.Parameters.Add("@nombre", SqlDbType.VarChar).Value = df.nombreProducto;
            cmd.Parameters.Add("@descuento", SqlDbType.Decimal).Value = df.descuento;
            cmd.Parameters.Add("@valorUnitario", SqlDbType.Decimal).Value = df.valorUnitario;
            SqlParameter retval = cmd.Parameters.Add("@retorno", SqlDbType.VarChar);
            retval.Direction = ParameterDirection.ReturnValue;
            cmd.ExecuteNonQuery();
            retorno = (int)cmd.Parameters["@retorno"].Value;
            conexion.cerrarConexion();
            return retorno;
        }
        public int quitarProductoPrecompra(String codigo, int cantidad)
        {
            int retorno = -1;
            conexion.abrirConexion();
            SqlCommand cmd = new SqlCommand("uspQuitarProductoPrecompraProforma", conexion.obtenerConexion());
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@codigo", SqlDbType.VarChar).Value = codigo;
            cmd.Parameters.Add("@cantidad", SqlDbType.Int).Value = cantidad;
            SqlParameter retval = cmd.Parameters.Add("@retorno", SqlDbType.VarChar);
            retval.Direction = ParameterDirection.ReturnValue;
            cmd.ExecuteNonQuery();
            retorno = (int)cmd.Parameters["@retorno"].Value;
            conexion.cerrarConexion();
            return retorno;
        }
        public DataTable todaPrecompra()
        {
            DataTable dtPrecompra = new DataTable();
            conexion.abrirConexion();
            SqlCommand cmd = new SqlCommand("uspTodaPrecompraProforma", conexion.obtenerConexion());
            cmd.CommandType = CommandType.StoredProcedure;
            SqlDataReader reader = cmd.ExecuteReader();
            dtPrecompra.Load(reader);
            dtPrecompra.Columns[0].ColumnName = "Cantidad";
            dtPrecompra.Columns[1].ColumnName = "Código";
            dtPrecompra.Columns[2].ColumnName = "Detalle";
            dtPrecompra.Columns[3].ColumnName = "Desc(%)";
            dtPrecompra.Columns[4].ColumnName = "V. Unit.";
            dtPrecompra.Columns[5].ColumnName = "V. Total";
            conexion.cerrarConexion();
            return dtPrecompra;
        }
        public DetalleProforma obtenerRegistroPrecompraProforma(String cadena)
        {

            conexion.abrirConexion();
            SqlCommand cmd = new SqlCommand("uspObtenerProductoPrecompraProforma", conexion.obtenerConexion());
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@codigo", SqlDbType.VarChar).Value = cadena;
            SqlDataReader reader = cmd.ExecuteReader();
            if (reader.HasRows)
            {
                string[] datos = new string[2];
                int codigoFactura = -1;
                int cantidad = -1;
                Decimal descuento = 0;
                Decimal valorUnitario = 0;
                Decimal valorTotal = 0;
                while (reader.Read())
                {
                    codigoFactura = reader.GetInt32(0);
                    cantidad = reader.GetInt32(1);
                    datos[0] = reader.GetString(2);
                    datos[1] = reader.GetString(3);
                    descuento = reader.GetDecimal(4);
                    valorUnitario = reader.GetDecimal(5);
                    valorTotal = reader.GetDecimal(6);

                }
                DetalleProforma df = new DetalleProforma(codigoFactura, cantidad, datos[0], datos[1], descuento, valorUnitario, valorTotal);
                conexion.cerrarConexion();
                return df;
            }
            conexion.cerrarConexion();
            return null;
        }
        public int insertarDetalleProforma()
        {
            int retorno = -1;
            conexion.abrirConexion();
            SqlCommand cmd = new SqlCommand("uspTraspasarPPaDP", conexion.obtenerConexion());
            cmd.CommandType = CommandType.StoredProcedure;
            SqlParameter retval = cmd.Parameters.Add("@retorno", SqlDbType.VarChar);
            retval.Direction = ParameterDirection.ReturnValue;
            cmd.ExecuteNonQuery();
            retorno = (int)cmd.Parameters["@retorno"].Value;
            conexion.cerrarConexion();
            return retorno;
        }
    }
}
