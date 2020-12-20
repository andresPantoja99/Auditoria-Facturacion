using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace sistema_de_facturacion.Modelo
{
    class ConexionDB
    {
        String host = "Data source=DESKTOP-T626JJJ\\GRUPO2;Initial Catalog=sochef;Integrated Security=True";
        public SqlConnection conexion = new SqlConnection();
        public ConexionDB()
        {
            conexion.ConnectionString = host;
        }
        public void abrirConexion()
        {
            try
            {
                conexion.Open();
                //MessageBox.Show("Conectado exitósamente!");

            }
            catch(Exception e)
            {
               MessageBox.Show("Conexión errónea, reintentando..."+e);
            }
        }
        public void cerrarConexion()
        {
            conexion.Close();
        }
        public SqlConnection obtenerConexion()
        {
            return conexion;
        }
    }
}
