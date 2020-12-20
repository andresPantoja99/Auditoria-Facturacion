using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sistema_de_facturacion.Modelo
{
    class Producto
    {
        public String codigo { get; set; }
        public String nombre { get; set; }
        public int unidadesDisponibles { get; set; }
        public decimal precioVentaUnitario { get; set; }
        public decimal descuento { get; set; }
        public String unidadVenta { get; set; }
        public int unidadesVendidas { get; set; }
        public decimal precioAdquisicion { get; set; }
        public DateTime ultimoIngreso { get; set; }
        public decimal precioGananciaMinima { get; set; }
        public String proveedorRUC { get; set; }
        public int baja { get; set; }
        public int categoriaID { get; set; }
        public int unidadesMinimas { get; set; }
        ConexionDB conexion = new ConexionDB();
        public Producto(string codigo, string nombre, int unidadesDisponibles, decimal precioVentaUnitario, decimal descuento, string unidadVenta, int unidadesVendidas, decimal precioAdquisicion, DateTime ultimoIngreso, decimal precioGananciaMinima, string proveedorRUC, int baja, int categoriaID, int unidadesMinimas)
        {
            this.codigo = codigo;
            this.nombre = nombre;
            this.unidadesDisponibles = unidadesDisponibles;
            this.precioVentaUnitario = precioVentaUnitario;
            this.descuento = descuento;
            this.unidadVenta = unidadVenta;
            this.unidadesVendidas = unidadesVendidas;
            this.precioAdquisicion = precioAdquisicion;
            this.ultimoIngreso = ultimoIngreso;
            this.precioGananciaMinima = precioGananciaMinima;
            this.proveedorRUC = proveedorRUC;
            this.baja = baja;
            this.categoriaID = categoriaID;
            this.unidadesMinimas = unidadesMinimas;
        }
        public Producto()
        {

        }
        public Producto obtenerProducto(String cadena)
        {
            conexion.abrirConexion();
            SqlCommand cmd = new SqlCommand("uspObtenerProducto", conexion.obtenerConexion());
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@busqueda", SqlDbType.VarChar).Value = cadena;
            SqlDataReader reader = cmd.ExecuteReader();
            if (reader.HasRows)
            {
                string[] datos = new string[4];
                int[] datos1 = new int[5];
                decimal[] datos2 = new decimal[4];
                DateTime fecha = DateTime.Now;
                while (reader.Read())
                {
                    datos[0] = reader.GetString(0).TrimEnd();
                    datos[1] = reader.GetString(1).TrimEnd();
                    datos[2] = reader.GetString(5).TrimEnd();
                    datos[3] = reader.GetString(10).TrimEnd();
                    datos1[0] = reader.GetInt32(2);
                    datos1[1] = reader.GetInt32(6);
                    datos1[2] = reader.GetInt32(11);
                    datos1[3] = reader.GetInt32(12);
                    datos1[4] = reader.GetInt32(13);
                    datos2[0] = reader.GetDecimal(3);
                    datos2[1] = reader.GetDecimal(4);
                    datos2[2] = reader.GetDecimal(7);
                    datos2[3] = reader.GetDecimal(9);
                    fecha = reader.GetDateTime(8);

                }
                Producto obtenido = new Producto(datos[0], datos[1], datos1[0], datos2[0], datos2[1], datos[2], datos1[1], datos2[2], fecha, datos2[3], datos[3], datos1[2],datos1[3],datos1[4]);
                conexion.cerrarConexion();
                return obtenido;
            }
            conexion.cerrarConexion();
            return null;
        }
        public int agregarProducto(Producto producto)
        {

            if (obtenerProducto(producto.nombre) != null)
            {
                return -1;
            }
            conexion.abrirConexion();
            SqlCommand cmd = new SqlCommand("uspRegistrarProducto", conexion.obtenerConexion());
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@codigo", SqlDbType.VarChar).Value = producto.codigo;
            cmd.Parameters.Add("@nombre", SqlDbType.VarChar).Value = producto.nombre;
            cmd.Parameters.Add("@unidadesDisponibles", SqlDbType.Int).Value = producto.unidadesDisponibles;
            cmd.Parameters.Add("@precioUnitario", SqlDbType.Decimal).Value = producto.precioVentaUnitario;
            cmd.Parameters.Add("@descuento", SqlDbType.Decimal).Value = producto.descuento;
            cmd.Parameters.Add("@unidadVenta", SqlDbType.VarChar).Value = producto.unidadVenta;
            cmd.Parameters.Add("@vendidos", SqlDbType.VarChar).Value = producto.unidadesVendidas;
            cmd.Parameters.Add("@precioOriginal", SqlDbType.Decimal).Value = producto.precioAdquisicion;
            //Realizar casting de Producto.DateTime hacia string.
            cmd.Parameters.Add("@nultimoIngreso", SqlDbType.VarChar).Value = producto.ultimoIngreso;
            cmd.Parameters.Add("@gananciaMin", SqlDbType.Decimal).Value = producto.precioGananciaMinima;
            cmd.Parameters.Add("@proveedorRuc", SqlDbType.VarChar).Value = producto.proveedorRUC;
            cmd.Parameters.Add("@categoria", SqlDbType.Int).Value = producto.categoriaID;
            cmd.Parameters.Add("@unidadesMinimas", SqlDbType.Int).Value = producto.unidadesMinimas;
            SqlParameter retval = cmd.Parameters.Add("@retorno", SqlDbType.VarChar);
            retval.Direction = ParameterDirection.ReturnValue;
            cmd.ExecuteNonQuery();
            int retorno = (int)cmd.Parameters["@retorno"].Value;
            conexion.cerrarConexion();
            return retorno;
        }
        public int modificarProducto(Producto producto)
        {

            conexion.abrirConexion();
            SqlCommand cmd = new SqlCommand("uspModificarProducto", conexion.obtenerConexion());
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@codigo", SqlDbType.VarChar).Value = producto.codigo;
            //cmd.Parameters.Add("@nombre", SqlDbType.VarChar).Value = producto.nombre;
            cmd.Parameters.Add("@unidadesDisponibles", SqlDbType.Int).Value = producto.unidadesDisponibles;
            cmd.Parameters.Add("@precioUnitario", SqlDbType.Decimal).Value = producto.precioVentaUnitario;
            cmd.Parameters.Add("@descuento", SqlDbType.Decimal).Value = producto.descuento;
            cmd.Parameters.Add("@unidadVenta", SqlDbType.VarChar).Value = producto.unidadVenta;
            cmd.Parameters.Add("@vendidos", SqlDbType.VarChar).Value = producto.unidadesVendidas;
            cmd.Parameters.Add("@precioOriginal", SqlDbType.Decimal).Value = producto.precioAdquisicion;
            //Realizar casting de Producto.DateTime hacia string.
            cmd.Parameters.Add("@nultimoIngreso", SqlDbType.VarChar).Value = producto.ultimoIngreso;
            cmd.Parameters.Add("@gananciaMin", SqlDbType.Decimal).Value = producto.precioGananciaMinima;
            cmd.Parameters.Add("@proveedorRuc", SqlDbType.VarChar).Value = producto.proveedorRUC;
            cmd.Parameters.Add("@categoria", SqlDbType.Int).Value = producto.categoriaID;
            cmd.Parameters.Add("@unidadesMinimas", SqlDbType.Int).Value = producto.unidadesMinimas;
            SqlParameter retval = cmd.Parameters.Add("@retorno", SqlDbType.VarChar);
            retval.Direction = ParameterDirection.ReturnValue;
            cmd.ExecuteNonQuery();
            int retorno = (int)cmd.Parameters["@retorno"].Value;
            conexion.cerrarConexion();
            return retorno;
        }
        public DataTable buscarProducto(int decision, String cadena)
        {
            DataTable dtProductos = new DataTable();
            conexion.abrirConexion();
            SqlCommand cmd = new SqlCommand("uspBuscarProducto", conexion.obtenerConexion());
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@decision", SqlDbType.VarChar).Value = decision;
            cmd.Parameters.Add("@busqueda", SqlDbType.VarChar).Value = cadena;
            SqlDataReader reader = cmd.ExecuteReader();
            dtProductos.Load(reader);
            dtProductos.Columns[0].ColumnName = "Código";
            dtProductos.Columns[1].ColumnName = "Nombre";
            dtProductos.Columns[2].ColumnName = "Unidades Disponibles";
            dtProductos.Columns[3].ColumnName = "Precio Unitario";
            dtProductos.Columns[4].ColumnName = "Descuento";
            dtProductos.Columns[5].ColumnName = "Unidad de Venta";
            dtProductos.Columns[6].ColumnName = "Unidades Vendidas";
            dtProductos.Columns[7].ColumnName = "Precio Original";
            dtProductos.Columns[8].ColumnName = "Último Reabastecimiento";
            dtProductos.Columns[9].ColumnName = "Ganancia Mínima";
            dtProductos.Columns[10].ColumnName = "RUC Proveedor";
            dtProductos.Columns[11].ColumnName = "Estado";
            dtProductos.Columns[12].ColumnName = "Código Categoría";
            dtProductos.Columns[13].ColumnName = "Stock Mínimo";
            conexion.cerrarConexion();
            return dtProductos;
        }
        public DataTable buscarProductoVender(String cadena)
        {
            DataTable dtProductos = new DataTable();
            conexion.abrirConexion();
            SqlCommand cmd = new SqlCommand("uspBuscarProductoVender", conexion.obtenerConexion());
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@busqueda", SqlDbType.VarChar).Value = cadena;
            SqlDataReader reader = cmd.ExecuteReader();
            dtProductos.Load(reader);
            dtProductos.Columns[0].ColumnName = "Código";
            dtProductos.Columns[1].ColumnName = "Nombre";
            dtProductos.Columns[2].ColumnName = "Precio Unitario";
            dtProductos.Columns[3].ColumnName = "Unidades Disponibles";
            
            conexion.cerrarConexion();
            return dtProductos;
        }
        public int darDeBajaProducto(String cadena)
        {
            conexion.abrirConexion();
            SqlCommand cmd = new SqlCommand("uspDarBajaProducto", conexion.obtenerConexion());
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@codigo", SqlDbType.VarChar).Value = cadena;
            SqlParameter retval = cmd.Parameters.Add("@retorno", SqlDbType.VarChar);
            retval.Direction = ParameterDirection.ReturnValue;
            cmd.ExecuteNonQuery();
            int retorno = (int)cmd.Parameters["@retorno"].Value;
            conexion.cerrarConexion();
            return retorno;
        }
        public int darDeAltaProducto(String cadena)
        {
            conexion.abrirConexion();
            SqlCommand cmd = new SqlCommand("uspDarAltaProducto", conexion.obtenerConexion());
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@codigo", SqlDbType.VarChar).Value = cadena;
            SqlParameter retval = cmd.Parameters.Add("@retorno", SqlDbType.VarChar);
            retval.Direction = ParameterDirection.ReturnValue;
            cmd.ExecuteNonQuery();
            int retorno = (int)cmd.Parameters["@retorno"].Value;
            conexion.cerrarConexion();
            return retorno;
        }
        public DataTable segmentarProductos(int decision)
        {
            DataTable dtProductos = new DataTable();
            conexion.abrirConexion();
            SqlCommand cmd = new SqlCommand("uspSegmentarProductos", conexion.obtenerConexion());
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@decision", SqlDbType.VarChar).Value = decision;
            SqlDataReader reader = cmd.ExecuteReader();
            dtProductos.Load(reader);
            dtProductos.Columns[0].ColumnName = "Código";
            dtProductos.Columns[1].ColumnName = "Nombre";
            dtProductos.Columns[2].ColumnName = "Unidades Vendidas";
            dtProductos.Columns[3].ColumnName = "Unidades Disponibles";
            dtProductos.Columns[4].ColumnName = "Precio de Venta Unitario";
            dtProductos.Columns[5].ColumnName = "Último Reabastecimiento";
            conexion.cerrarConexion();
            return dtProductos;
        }
    }
}