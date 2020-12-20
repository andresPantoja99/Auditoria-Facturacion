using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sistema_de_facturacion.Modelo
{
    class ParametroM
    {
        public decimal iva { get; set; }
        public int id { get; set; }
        public string metodoPago { get; set; }
        ConexionDB conexion = new ConexionDB();
        public ParametroM(decimal iva, int id)
        {
            this.iva = iva;
            this.id = id;
        }

        public ParametroM(string metodoPago)
        {
            this.metodoPago = metodoPago;
        }

        public ParametroM()
        {
        }
        public ParametroM obtenerIVA()
        {
            conexion.abrirConexion();
            SqlCommand cmd = new SqlCommand("uspObtenerIVA", conexion.obtenerConexion());
            cmd.CommandType = CommandType.StoredProcedure;
            SqlDataReader reader = cmd.ExecuteReader();
            if (reader.HasRows)
            {
                decimal valor = 0;

                while (reader.Read())
                {
                    valor = reader.GetDecimal(1);

                }
                ParametroM obtenido = new ParametroM(valor,1);
                conexion.cerrarConexion();
                return obtenido;
            }
            conexion.cerrarConexion();
            return null;
        }
        public int modificarIVA(ParametroM parametro)
        {
            conexion.abrirConexion();
            SqlCommand cmd = new SqlCommand("uspActualizarIva", conexion.obtenerConexion());
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@iva", SqlDbType.Decimal).Value = parametro.iva;
            SqlParameter retval = cmd.Parameters.Add("@retorno", SqlDbType.VarChar);
            retval.Direction = ParameterDirection.ReturnValue;
            cmd.ExecuteNonQuery();
            int retorno = (int)cmd.Parameters["@retorno"].Value;
            conexion.cerrarConexion();
            return retorno;
        }
        public int añadirPago(String metodo)
        {
            conexion.abrirConexion();
            SqlCommand cmd = new SqlCommand("uspInsertarPago", conexion.obtenerConexion());
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@pago", SqlDbType.VarChar).Value = metodo;
            SqlParameter retval = cmd.Parameters.Add("@retorno", SqlDbType.VarChar);
            retval.Direction = ParameterDirection.ReturnValue;
            cmd.ExecuteNonQuery();
            int retorno = (int)cmd.Parameters["@retorno"].Value;
            conexion.cerrarConexion();
            return retorno;
        }
        public DataTable todoPago()
        {
            DataTable dtPagos = new DataTable();
            conexion.abrirConexion();
            SqlCommand cmd = new SqlCommand("uspMetodosPago", conexion.obtenerConexion());
            cmd.CommandType = CommandType.StoredProcedure;
            SqlDataReader reader = cmd.ExecuteReader();
            dtPagos.Load(reader);
            conexion.cerrarConexion();
            return dtPagos;
        }
    }
}
