using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Security.Cryptography;
using System.Windows.Forms;
using System.Configuration;

namespace sistema_de_facturacion.Modelo
{
    public class Usuario
    {
        public String usuario { get; set; }
        public String contrasena { get; set; }
        public String nombres{ get; set; }
        public String apellidos { get; set; }
        public String rol { get; set; }
        public byte[] huella { get; set; }
        ConexionDB conexion = new ConexionDB();

        public Usuario(string usuario, string contrasena, string nombres, string apellidos, string rol, byte[] huella)
        {
            this.usuario = usuario;
            this.contrasena = contrasena;
            this.nombres = nombres;
            this.apellidos = apellidos;
            this.rol = rol;
            this.huella = huella;
        }

        public Usuario()
        {

        }
        public Usuario obtenerUsuario(String cadena)
        {
            conexion.abrirConexion();
            SqlCommand cmd = new SqlCommand("uspObtenerUsuario", conexion.obtenerConexion());
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@busqueda", SqlDbType.VarChar).Value = cadena;
            SqlDataReader reader = cmd.ExecuteReader();
            if (reader.HasRows)
            {
                string[] datos = new string[5];
                byte[] huella = null;
                while (reader.Read())
                {
                    datos[0] = reader.GetString(0).TrimEnd();
                    datos[1] = reader.GetString(1).TrimEnd();
                    datos[2] = reader.GetString(2).TrimEnd();
                    datos[3] = reader.GetString(3).TrimEnd();
                    datos[4] = reader.GetString(4).TrimEnd();
                    if (reader.IsDBNull(5))
                    {
                        huella = null;
                    }
                    else
                    {
                        huella = (byte[])reader[5];
                    }

                }
                conexion.cerrarConexion();
                Usuario obtenido = new Usuario(datos[0], datos[1], datos[2], datos[3],datos[4],huella);
                return obtenido;
            }
            conexion.cerrarConexion();
            return null;
        }
        public int agregarUsuario(Usuario usuario)
        {

            if (obtenerUsuario(usuario.usuario) != null)
            {
                return -1;
            }
            conexion.abrirConexion();
            SqlCommand cmd = new SqlCommand("uspRegistrarUsuario", conexion.obtenerConexion());
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@usuario", SqlDbType.VarChar).Value = usuario.usuario;
            String contrasena = md5_string(usuario.contrasena);
            cmd.Parameters.Add("@psswd", SqlDbType.VarChar).Value = contrasena;
            cmd.Parameters.Add("@nombres", SqlDbType.VarChar).Value = usuario.nombres;
            cmd.Parameters.Add("@apellidos", SqlDbType.VarChar).Value = usuario.apellidos;
            cmd.Parameters.Add("@rol", SqlDbType.VarChar).Value = usuario.rol;
            cmd.Parameters.Add("@huella", SqlDbType.VarBinary).Value = usuario.huella;
            SqlParameter retval = cmd.Parameters.Add("@retorno", SqlDbType.VarChar);
            retval.Direction = ParameterDirection.ReturnValue;
            cmd.ExecuteNonQuery();
            int retorno = (int)cmd.Parameters["@retorno"].Value;
            conexion.cerrarConexion();
            return retorno;
        }
        public int agregarUsuarioSinHuella(Usuario usuario)
        {

            if (obtenerUsuario(usuario.usuario) != null)
            {
                return -1;
            }
            conexion.abrirConexion();
            SqlCommand cmd = new SqlCommand("uspRegistrarUsuarioSinHuella", conexion.obtenerConexion());
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@usuario", SqlDbType.VarChar).Value = usuario.usuario;
            String contrasena = md5_string(usuario.contrasena);
            cmd.Parameters.Add("@psswd", SqlDbType.VarChar).Value = contrasena;
            cmd.Parameters.Add("@nombres", SqlDbType.VarChar).Value = usuario.nombres;
            cmd.Parameters.Add("@apellidos", SqlDbType.VarChar).Value = usuario.apellidos;
            cmd.Parameters.Add("@rol", SqlDbType.VarChar).Value = usuario.rol;
            SqlParameter retval = cmd.Parameters.Add("@retorno", SqlDbType.VarChar);
            retval.Direction = ParameterDirection.ReturnValue;
            cmd.ExecuteNonQuery();
            int retorno = (int)cmd.Parameters["@retorno"].Value;
            conexion.cerrarConexion();
            return retorno;
        }
        public int modificarRol(Usuario usuario)
        {
            conexion.abrirConexion();
            SqlCommand cmd = new SqlCommand("uspModificarUsuarioRol", conexion.obtenerConexion());
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@usuario", SqlDbType.VarChar).Value = usuario.usuario;
            cmd.Parameters.Add("@rol", SqlDbType.VarChar).Value = usuario.rol;
            SqlParameter retval = cmd.Parameters.Add("@retorno", SqlDbType.VarChar);
            retval.Direction = ParameterDirection.ReturnValue;
            cmd.ExecuteNonQuery();
            int retorno = (int)cmd.Parameters["@retorno"].Value;
            conexion.cerrarConexion();
            return retorno;
        }
        public int modificarUsuario(Usuario usuario)
        {
            conexion.abrirConexion();
            SqlCommand cmd = new SqlCommand("uspModificarUsuario", conexion.obtenerConexion());
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@usuario", SqlDbType.VarChar).Value = usuario.usuario.TrimEnd();
            String contrasena = md5_string(usuario.contrasena.TrimEnd());
            cmd.Parameters.Add("@psswd", SqlDbType.VarChar).Value = contrasena;
            SqlParameter retval = cmd.Parameters.Add("@retorno", SqlDbType.VarChar);
            retval.Direction = ParameterDirection.ReturnValue;
            cmd.ExecuteNonQuery();
            int retorno = (int)cmd.Parameters["@retorno"].Value;
            conexion.cerrarConexion();
            return retorno;
        }
        public int eliminarUsuario(String usuario)
        {
            conexion.abrirConexion();
            SqlCommand cmd = new SqlCommand("uspEliminarUsuario", conexion.obtenerConexion());
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@usuario", SqlDbType.VarChar).Value = usuario;
            SqlParameter retval = cmd.Parameters.Add("@retorno", SqlDbType.VarChar);
            retval.Direction = ParameterDirection.ReturnValue;
            cmd.ExecuteNonQuery();
            int retorno = (int)cmd.Parameters["@retorno"].Value;
            conexion.cerrarConexion();
            return retorno;
        }
        public DataTable buscarUsuario(int decision, String cadena)
        {
            DataTable dtUsuarios = new DataTable();
            conexion.abrirConexion();
            SqlCommand cmd = new SqlCommand("uspBuscarUsuario", conexion.obtenerConexion());
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@decision", SqlDbType.VarChar).Value = decision;
            cmd.Parameters.Add("@busqueda", SqlDbType.VarChar).Value = cadena;
            SqlDataReader reader = cmd.ExecuteReader();
            dtUsuarios.Load(reader);
            dtUsuarios.Columns[0].ColumnName = "ID de Usuario";
            dtUsuarios.Columns[1].ColumnName = "Nombres";
            dtUsuarios.Columns[2].ColumnName = "Apellidos";
            dtUsuarios.Columns[3].ColumnName = "Rol";
            conexion.cerrarConexion();
            return dtUsuarios;
        }
        private MD5 md5_convertor = System.Security.Cryptography.MD5.Create();
        byte[] inputBytes, hash;
        private StringBuilder builder_string;
        private string md5_string(string pass)
        {
            inputBytes = System.Text.Encoding.ASCII.GetBytes(pass);
            hash = md5_convertor.ComputeHash(inputBytes);
            builder_string = new StringBuilder();
            for (byte i = 0; i < hash.Length; i++)
            {
                builder_string.Append(hash[i].ToString("X2"));
            }
            return builder_string.ToString();
        }
        public int validarIngreso(String[] usuario, int decision)
        {
            conexion.abrirConexion();
            SqlCommand cmd = new SqlCommand("uspLogeo", conexion.obtenerConexion());
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@usera", SqlDbType.VarChar).Value = usuario[0].TrimEnd();
            String contrasena = md5_string(usuario[1].TrimEnd());
            cmd.Parameters.Add("@psswd", SqlDbType.VarChar).Value = contrasena;
            cmd.Parameters.Add("@huella", SqlDbType.VarChar).Value = usuario[2];
            cmd.Parameters.Add("@decision", SqlDbType.VarChar).Value = decision;
            SqlParameter retval = cmd.Parameters.Add("@retorno", SqlDbType.VarChar);
            retval.Direction = ParameterDirection.ReturnValue;
            cmd.ExecuteNonQuery();
            int retorno = (int)cmd.Parameters["@retorno"].Value;
            conexion.cerrarConexion();
            return retorno;
        }
    }
}
