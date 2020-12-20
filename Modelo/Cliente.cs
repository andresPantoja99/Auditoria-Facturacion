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
    public class Cliente
    {
        
        public String  cRUC { get; set; }
        public String nombre { get; set; }
        public String apellido { get; set; }
        public String telefono { get; set; }
        public String direccion { get; set; }
        public String ciudad { get; set; }
        public String correo { get; set; }
        public byte[] huella { get; set; }
        public String tipo { get; set; }
        public String baja { get; set; }
        ConexionDB conexion = new ConexionDB();

        public Cliente(string cRUC, string nombre, string apellido, string telefono, string direccion, string ciudad, string correo, byte[] huella, string tipo, string baja)
        {
            this.cRUC = cRUC;
            this.nombre = nombre;
            this.apellido = apellido;
            this.telefono = telefono;
            this.direccion = direccion;
            this.ciudad = ciudad;
            this.correo = correo;
            this.huella = huella;
            this.tipo = tipo;
            this.baja = baja;
        }

        public Cliente()
        {
          
        }
        public int agregarCliente(Cliente cliente)
        {
            
            if (obtenerCliente(cliente.cRUC) != null)
            {
                return -1;
            }
            conexion.abrirConexion();
            SqlCommand cmd = new SqlCommand("uspRegistrarCliente", conexion.obtenerConexion());
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@rucCI", SqlDbType.VarChar).Value = cliente.cRUC;
            cmd.Parameters.Add("@nombres", SqlDbType.VarChar).Value = cliente.nombre;
            cmd.Parameters.Add("@apellidos", SqlDbType.VarChar).Value = cliente.apellido;
            cmd.Parameters.Add("@telefono", SqlDbType.VarChar).Value = cliente.telefono;
            cmd.Parameters.Add("@direccionDomiciliaria", SqlDbType.VarChar).Value = cliente.direccion;
            cmd.Parameters.Add("@ciudad", SqlDbType.VarChar).Value = cliente.ciudad;
            cmd.Parameters.Add("@email", SqlDbType.VarChar).Value = cliente.correo;
            cmd.Parameters.Add("@huella", SqlDbType.VarBinary).Value = cliente.huella;
            cmd.Parameters.Add("@tipo", SqlDbType.VarChar).Value = cliente.tipo;
            SqlParameter retval = cmd.Parameters.Add("@retorno", SqlDbType.VarChar);
            retval.Direction = ParameterDirection.ReturnValue;
            cmd.ExecuteNonQuery();
            int retorno = (int)cmd.Parameters["@retorno"].Value;
            conexion.cerrarConexion();
            return retorno;
        }
        public int agregarClienteSinHuella(Cliente cliente)
        {

            if (obtenerCliente(cliente.cRUC) != null)
            {
                return -1;
            }
            conexion.abrirConexion();
            SqlCommand cmd = new SqlCommand("uspRegistrarClienteSinHuella", conexion.obtenerConexion());
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@rucCI", SqlDbType.VarChar).Value = cliente.cRUC;
            cmd.Parameters.Add("@nombres", SqlDbType.VarChar).Value = cliente.nombre;
            cmd.Parameters.Add("@apellidos", SqlDbType.VarChar).Value = cliente.apellido;
            cmd.Parameters.Add("@telefono", SqlDbType.VarChar).Value = cliente.telefono;
            cmd.Parameters.Add("@direccionDomiciliaria", SqlDbType.VarChar).Value = cliente.direccion;
            cmd.Parameters.Add("@ciudad", SqlDbType.VarChar).Value = cliente.ciudad;
            cmd.Parameters.Add("@email", SqlDbType.VarChar).Value = cliente.correo;
            cmd.Parameters.Add("@tipo", SqlDbType.VarChar).Value = cliente.tipo;
            SqlParameter retval = cmd.Parameters.Add("@retorno", SqlDbType.VarChar);
            retval.Direction = ParameterDirection.ReturnValue;
            cmd.ExecuteNonQuery();
            int retorno = (int)cmd.Parameters["@retorno"].Value;
            conexion.cerrarConexion();
            return retorno;
        }
        public DataTable buscarCliente(int decision, String cadena)
        {
            DataTable dtClientes = new DataTable();
            conexion.abrirConexion();
            SqlCommand cmd = new SqlCommand("uspBuscarCliente", conexion.obtenerConexion());
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@decision", SqlDbType.VarChar).Value = decision;
            cmd.Parameters.Add("@busqueda", SqlDbType.VarChar).Value = cadena;
            SqlDataReader reader = cmd.ExecuteReader();
            dtClientes.Load(reader);
            dtClientes.Columns[0].ColumnName = "RUC/C.I./Pasaporte";
            dtClientes.Columns[1].ColumnName = "Nombre o Razón Social";
            dtClientes.Columns[2].ColumnName = "Apellido(s)";
            dtClientes.Columns[3].ColumnName = "Teléfono";
            dtClientes.Columns[4].ColumnName = "Dirección";
            dtClientes.Columns[5].ColumnName = "Ciudad";
            dtClientes.Columns[6].ColumnName = "Dirección de Correo Electrónico";
            dtClientes.Columns[7].ColumnName = "Huella Digital";
            dtClientes.Columns[8].ColumnName = "Tipo de Persona";
            dtClientes.Columns[9].ColumnName = "Estado";
            conexion.cerrarConexion();
            return dtClientes;
        }
        public Cliente obtenerCliente(String cadena)
        {
            
            conexion.abrirConexion();
            SqlCommand cmd = new SqlCommand("uspObtenerCliente", conexion.obtenerConexion());
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@busqueda", SqlDbType.VarChar).Value = cadena;
            SqlDataReader reader = cmd.ExecuteReader();
            if (reader.HasRows)
            {
                string[] datos = new string[10];
                byte[] huella = null;
                while (reader.Read())
                {
                    datos[0] = reader.GetString(0).TrimEnd();
                    datos[1] = reader.GetString(1).TrimEnd();
                    datos[2] = reader.GetString(2).TrimEnd();
                    datos[3] = reader.GetString(3).TrimEnd();
                    datos[4] = reader.GetString(4).TrimEnd();
                    datos[5] = reader.GetString(5).TrimEnd();
                    datos[6] = reader.GetString(6).TrimEnd();
                    if (reader.IsDBNull(7))
                    {
                        huella = null;
                    }
                    else
                    {
                        huella = (byte[])reader[7];
                    }
                    
                    datos[8] = reader.GetString(8).TrimEnd();
                    datos[9] = reader.GetString(9).TrimEnd();
                }
                Cliente obtenido = new Cliente(datos[0], datos[1], datos[2], datos[3], datos[4], datos[5], datos[6], huella, datos[8], datos[9]);
                conexion.cerrarConexion();
                return obtenido;
            }
            conexion.cerrarConexion();
            return null;
        }
        public int modificarCliente(Cliente cliente)
        {
            conexion.abrirConexion();
            SqlCommand cmd = new SqlCommand("uspModificarCliente", conexion.obtenerConexion());
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@rucCi", SqlDbType.VarChar).Value = cliente.cRUC;
            cmd.Parameters.Add("@telefono", SqlDbType.VarChar).Value = cliente.telefono;
            cmd.Parameters.Add("@direccionDomiciliaria", SqlDbType.VarChar).Value = cliente.direccion;
            cmd.Parameters.Add("@ciudad", SqlDbType.VarChar).Value = cliente.ciudad;
            cmd.Parameters.Add("@email", SqlDbType.VarChar).Value = cliente.correo;
            SqlParameter retval = cmd.Parameters.Add("@retorno", SqlDbType.VarChar);
            retval.Direction = ParameterDirection.ReturnValue;
            cmd.ExecuteNonQuery();
            int retorno = (int)cmd.Parameters["@retorno"].Value;
            conexion.cerrarConexion();
            return retorno;
        }
        public int darDeBajaCliente(String cadena)
        {
            conexion.abrirConexion();
            SqlCommand cmd = new SqlCommand("uspDarBajaCliente", conexion.obtenerConexion());
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@rucCI", SqlDbType.VarChar).Value = cadena;
            SqlParameter retval = cmd.Parameters.Add("@retorno", SqlDbType.VarChar);
            retval.Direction = ParameterDirection.ReturnValue;
            cmd.ExecuteNonQuery();
            int retorno = (int)cmd.Parameters["@retorno"].Value;
            conexion.cerrarConexion();
            return retorno;
        }
        public int darDeAltaCliente(String cadena)
        {
            conexion.abrirConexion();
            SqlCommand cmd = new SqlCommand("uspDarAltaCliente", conexion.obtenerConexion());
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@rucCI", SqlDbType.VarChar).Value = cadena;
            SqlParameter retval = cmd.Parameters.Add("@retorno", SqlDbType.VarChar);
            retval.Direction = ParameterDirection.ReturnValue;
            cmd.ExecuteNonQuery();
            int retorno = (int)cmd.Parameters["@retorno"].Value;
            conexion.cerrarConexion();
            return retorno;
        }
    }
}
