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
    public class Categoria
    {
        public String nombre { get; set; }
        ConexionDB conexion = new ConexionDB();
        public Categoria(string nombre)
        {
            this.nombre = nombre;
        }

        public Categoria()
        {
        }
        public Categoria obtenerCategoria(String cadena)
        {

            conexion.abrirConexion();
            SqlCommand cmd = new SqlCommand("uspObtenerCategoria", conexion.obtenerConexion());
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@busqueda", SqlDbType.VarChar).Value = cadena;
            SqlDataReader reader = cmd.ExecuteReader();
            if (reader.HasRows)
            {
                string nombre="";
                
                while (reader.Read())
                {
                    nombre = reader.GetString(1).TrimEnd();
                    
                }
                Categoria obtenida = new Categoria(nombre);
                conexion.cerrarConexion();
                return obtenida;
            }
            conexion.cerrarConexion();
            return null;
        }
        public int agregarCategoria(Categoria categoria)
        {

            if (obtenerCategoria(categoria.nombre) != null)
            {
                return -1;
            }
            conexion.abrirConexion();
            SqlCommand cmd = new SqlCommand("uspRegistrarCategoria ", conexion.obtenerConexion());
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@nombreCategoria", SqlDbType.VarChar).Value = categoria.nombre;
            SqlParameter retval = cmd.Parameters.Add("@retorno", SqlDbType.VarChar);
            retval.Direction = ParameterDirection.ReturnValue;
            cmd.ExecuteNonQuery();
            int retorno = (int)cmd.Parameters["@retorno"].Value;
            conexion.cerrarConexion();
            return retorno;
        }
        public DataTable todaCategoria()
        {
            DataTable dtCategorias = new DataTable();
            conexion.abrirConexion();
            SqlCommand cmd = new SqlCommand("uspObtenerTodasCategorias", conexion.obtenerConexion());
            cmd.CommandType = CommandType.StoredProcedure;
            SqlDataReader reader = cmd.ExecuteReader();
            dtCategorias.Load(reader);
            conexion.cerrarConexion();
            return dtCategorias;
        }
        public int obtenerIDCategoria(String cadena)
        {
            conexion.abrirConexion();
            SqlCommand cmd = new SqlCommand("uspObtenerIDCategoria", conexion.obtenerConexion());
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@busqueda", SqlDbType.VarChar).Value = cadena;
            SqlDataReader reader = cmd.ExecuteReader();
            int id = -1;
            while (reader.Read())
            {
                id = reader.GetInt32(0);

            }
            conexion.cerrarConexion();
            return id;
        }
        public DataTable buscarCategoria(String cadena)
        {
            DataTable dtCategorias = new DataTable();
            conexion.abrirConexion();
            SqlCommand cmd = new SqlCommand("uspBuscarCategoria", conexion.obtenerConexion());
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@busqueda", SqlDbType.VarChar).Value = cadena;
            SqlDataReader reader = cmd.ExecuteReader();
            dtCategorias.Load(reader);
            dtCategorias.Columns[0].ColumnName = "Código de Categoría";
            dtCategorias.Columns[1].ColumnName = "Nombre de la Categoría";
            conexion.cerrarConexion();
            return dtCategorias;
        }
        public int modificarCategoria(Categoria antigua, Categoria categoria)
        {
            
            int id = categoria.obtenerIDCategoria(antigua.nombre);
            conexion.abrirConexion();
            SqlCommand cmd = new SqlCommand("uspModificarCategoria", conexion.obtenerConexion());
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@busqueda", SqlDbType.VarChar).Value = categoria.nombre;
            cmd.Parameters.Add("@id", SqlDbType.Int).Value = id;
            SqlParameter retval = cmd.Parameters.Add("@retorno", SqlDbType.VarChar);
            retval.Direction = ParameterDirection.ReturnValue;
            cmd.ExecuteNonQuery();
            int retorno = (int)cmd.Parameters["@retorno"].Value;
            conexion.cerrarConexion();
            return retorno;
        }
        public String obtenerNombreCategoria(int id)
        {
            conexion.abrirConexion();
            SqlCommand cmd = new SqlCommand("uspNombreCategoria", conexion.obtenerConexion());
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@busqueda", SqlDbType.VarChar).Value = id;
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
