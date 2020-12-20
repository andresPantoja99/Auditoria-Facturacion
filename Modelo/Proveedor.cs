using System;
using System.Collections.Generic;
using System.Linq;
using System.Data;
using System.Data.SqlClient;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sistema_de_facturacion.Modelo
{
    class Proveedor
    {
        public String ruc { get; set; }
        public String nombre { get; set; }
        public String telefono { get; set; }
        public String direccion { get; set; }
        public String ciudad { get; set; }
        public String correo { get; set; }
        public String personaContacto { get; set; }
        public String numeroContacto { get; set; }
        public int baja { get; set; }
        ConexionDB conexion = new ConexionDB();
        public Proveedor(string ruc, string nombre, string telefono, string direccion, string ciudad, string correo, string personaContacto, string numeroContacto, int baja)
        {
            this.ruc = ruc;
            this.nombre = nombre;
            this.telefono = telefono;
            this.direccion = direccion;
            this.ciudad = ciudad;
            this.correo = correo;
            this.personaContacto = personaContacto;
            this.numeroContacto = numeroContacto;
            this.baja = baja;
        }
        public Proveedor()
        {

        }
        public int agregarProveedor(Proveedor proveedor)
        {
            
            if (obtenerProveedor(proveedor.ruc) != null)
            {
                return -1;
            }
            conexion.abrirConexion();
            SqlCommand cmd = new SqlCommand("uspRegistrarProveedor", conexion.obtenerConexion());
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@ruc", SqlDbType.VarChar).Value = proveedor.ruc;
            cmd.Parameters.Add("@nombre", SqlDbType.VarChar).Value = proveedor.nombre;
            cmd.Parameters.Add("@telefono", SqlDbType.VarChar).Value = proveedor.telefono;
            cmd.Parameters.Add("@direccionInstalaciones", SqlDbType.VarChar).Value = proveedor.direccion;
            cmd.Parameters.Add("@ciudad", SqlDbType.VarChar).Value = proveedor.ciudad;
            cmd.Parameters.Add("@email", SqlDbType.VarChar).Value = proveedor.correo;
            cmd.Parameters.Add("@perContacto", SqlDbType.VarChar).Value = proveedor.personaContacto;
            cmd.Parameters.Add("@numPerContacto", SqlDbType.VarChar).Value = proveedor.numeroContacto;
            SqlParameter retval = cmd.Parameters.Add("@retorno", SqlDbType.VarChar);
            retval.Direction = ParameterDirection.ReturnValue;
            cmd.ExecuteNonQuery();
            int retorno = (int)cmd.Parameters["@retorno"].Value;
            conexion.cerrarConexion();
            return retorno;
        }
        public DataTable buscarProveedor(int decision, String cadena)
        {
            DataTable dtProveedores = new DataTable();
            conexion.abrirConexion();
            SqlCommand cmd = new SqlCommand("uspBuscarProveedor", conexion.obtenerConexion());
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@decision", SqlDbType.VarChar).Value = decision;
            cmd.Parameters.Add("@busqueda", SqlDbType.VarChar).Value = cadena;
            SqlDataReader reader = cmd.ExecuteReader();
            dtProveedores.Load(reader);
            dtProveedores.Columns[0].ColumnName = "RUC";
            dtProveedores.Columns[1].ColumnName = "Nombre";
            dtProveedores.Columns[2].ColumnName = "Teléfono";
            dtProveedores.Columns[3].ColumnName = "Dirección";
            dtProveedores.Columns[4].ColumnName = "Ciudad";
            dtProveedores.Columns[5].ColumnName = "Dirección de Correo Electrónico";
            dtProveedores.Columns[6].ColumnName = "Nombre de Persona de Contacto";
            dtProveedores.Columns[7].ColumnName = "Número de teléfono de persona de contacto";
            dtProveedores.Columns[8].ColumnName = "Estado";
            conexion.cerrarConexion();
            return dtProveedores;
        }
        public DataTable todoProveedor()
        {
            DataTable dtProveedores = new DataTable();
            conexion.abrirConexion();
            SqlCommand cmd = new SqlCommand("uspObtenerTodosProveedores", conexion.obtenerConexion());
            cmd.CommandType = CommandType.StoredProcedure;
            SqlDataReader reader = cmd.ExecuteReader();
            dtProveedores.Load(reader);
            conexion.cerrarConexion();
            return dtProveedores;
        }
        public Proveedor obtenerProveedor(String cadena)
        {
            conexion.abrirConexion();
            SqlCommand cmd = new SqlCommand("uspObtenerProveedor", conexion.obtenerConexion());
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@busqueda", SqlDbType.VarChar).Value = cadena;
            SqlDataReader reader = cmd.ExecuteReader();
            if (reader.HasRows)
            {
                string[] datos = new string[8];
                int baja = 99;
                while (reader.Read())
                {
                    datos[0] = reader.GetString(0).TrimEnd();
                    datos[1] = reader.GetString(1).TrimEnd();
                    datos[2] = reader.GetString(2).TrimEnd();
                    datos[3] = reader.GetString(3).TrimEnd();
                    datos[4] = reader.GetString(4).TrimEnd();
                    datos[5] = reader.GetString(5).TrimEnd();
                    datos[6] = reader.GetString(6).TrimEnd();
                    datos[7] = reader.GetString(7).TrimEnd();
                    baja = reader.GetInt32(8);
                }
                Proveedor obtenido = new Proveedor(datos[0], datos[1], datos[2], datos[3], datos[4], datos[5], datos[6], datos[7], baja);
                conexion.cerrarConexion();
                return obtenido;
            }
            conexion.cerrarConexion();
            return null;
        }
        public int modificarProveedor(Proveedor proveedor)
        {
            conexion.abrirConexion();
            SqlCommand cmd = new SqlCommand("uspModificarProveedor", conexion.obtenerConexion());
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@ruc", SqlDbType.VarChar).Value = proveedor.ruc;
            cmd.Parameters.Add("@telefono", SqlDbType.VarChar).Value = proveedor.telefono;
            cmd.Parameters.Add("@direccionInstalaciones", SqlDbType.VarChar).Value = proveedor.direccion;
            cmd.Parameters.Add("@ciudad", SqlDbType.VarChar).Value = proveedor.ciudad;
            cmd.Parameters.Add("@email", SqlDbType.VarChar).Value = proveedor.correo;
            cmd.Parameters.Add("@perContacto", SqlDbType.VarChar).Value = proveedor.personaContacto;
            cmd.Parameters.Add("@numPerContacto", SqlDbType.VarChar).Value = proveedor.numeroContacto;
            SqlParameter retval = cmd.Parameters.Add("@retorno", SqlDbType.VarChar);
            retval.Direction = ParameterDirection.ReturnValue;
            cmd.ExecuteNonQuery();
            int retorno = (int)cmd.Parameters["@retorno"].Value;
            conexion.cerrarConexion();
            return retorno;
        }
        public int darDeBajaProveedor(String cadena)
        {
            conexion.abrirConexion();
            SqlCommand cmd = new SqlCommand("uspDarBajaProveedor", conexion.obtenerConexion());
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@rucCI", SqlDbType.VarChar).Value = cadena;
            SqlParameter retval = cmd.Parameters.Add("@retorno", SqlDbType.VarChar);
            retval.Direction = ParameterDirection.ReturnValue;
            cmd.ExecuteNonQuery();
            int retorno = (int)cmd.Parameters["@retorno"].Value;
            conexion.cerrarConexion();
            return retorno;
        }
        public int darDeAltaProveedor(String cadena)
        {
            conexion.abrirConexion();
            SqlCommand cmd = new SqlCommand("uspDarAltaProveedor", conexion.obtenerConexion());
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@rucCI", SqlDbType.VarChar).Value = cadena;
            SqlParameter retval = cmd.Parameters.Add("@retorno", SqlDbType.VarChar);
            retval.Direction = ParameterDirection.ReturnValue;
            cmd.ExecuteNonQuery();
            int retorno = (int)cmd.Parameters["@retorno"].Value;
            conexion.cerrarConexion();
            return retorno;
        }
        public String obtenerRUCProveedor(String cadena)
        {
            conexion.abrirConexion();
            SqlCommand cmd = new SqlCommand("uspObtenerRUCProveedor", conexion.obtenerConexion());
            cmd.Parameters.Add("@busqueda", SqlDbType.VarChar).Value = cadena;
            cmd.CommandType = CommandType.StoredProcedure;
            SqlDataReader reader = cmd.ExecuteReader();
            String ruc = "";
            while (reader.Read())
            {
                ruc = reader.GetString(0);
            }
            conexion.cerrarConexion();
            return ruc;
        }
        public String obtenerNombreProveedor(String ruc)
        {
            conexion.abrirConexion();
            SqlCommand cmd = new SqlCommand("uspNombreProveedor", conexion.obtenerConexion());
            cmd.Parameters.Add("@busqueda", SqlDbType.VarChar).Value = ruc;
            cmd.CommandType = CommandType.StoredProcedure;
            SqlDataReader reader = cmd.ExecuteReader();
            String nombre = "";
            while (reader.Read())
            {
                nombre = reader.GetString(0);
            }
            conexion.cerrarConexion();
            return nombre;
        }
    }
}
