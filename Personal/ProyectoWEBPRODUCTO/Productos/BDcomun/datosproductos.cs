using Dominio;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BDcomun
{
    public class datosproductos
    {
        public static void Guardar(Producto producto)
        {
            SqlConnection connection = BaseData.EstablecerConexion();
            SqlCommand comando = new SqlCommand("insertProductos ", connection);
            comando.CommandType = System.Data.CommandType.StoredProcedure;

            comando.Parameters.AddWithValue("@Nombre", producto.Nombre);
            comando.Parameters.AddWithValue("@Descripcion", producto.Descripcion);
            comando.Parameters.AddWithValue("@Precio", producto.Precio);
            comando.Parameters.AddWithValue("@Stock", producto.Stock);

            SqlParameter falloparametro = new SqlParameter();
            falloparametro.ParameterName = "@IDProducto";
            falloparametro.SqlDbType = System.Data.SqlDbType.Int;
            falloparametro.Direction = System.Data.ParameterDirection.Output;
            comando.Parameters.Add(falloparametro);

            comando.ExecuteNonQuery();
            connection.Close();
        }
        public static void Modificar(Producto producto)
        {
            SqlConnection connection = BaseData.EstablecerConexion();
            SqlCommand comando = new SqlCommand("updateProductos", connection);
            comando.CommandType = System.Data.CommandType.StoredProcedure;


            comando.Parameters.AddWithValue("@Nombre", producto.Nombre);
            comando.Parameters.AddWithValue("@Descripcion", producto.Descripcion);
            comando.Parameters.AddWithValue("@Precio", producto.Precio);
            comando.Parameters.AddWithValue("@Stock", producto.Stock);
            comando.Parameters.AddWithValue("@IDProducto", producto.Id);
        }
        public static List<Producto> Obtener()
        {
            SqlConnection connection = BaseData.EstablecerConexion();
            List<Producto> lista = new List<Producto>();

            string consulta = "selectProductos";
            SqlCommand comando = new SqlCommand(consulta, connection);
            comando.CommandType = System.Data.CommandType.StoredProcedure;
            SqlDataReader reader = comando.ExecuteReader();

            while (reader.Read())
            {
                Producto producto = new Producto();
                producto.Id = reader.GetInt32(0);
                producto.Nombre = reader.GetString(1);
                producto.Descripcion = reader.GetString(2);
                producto.Precio = reader.GetString(3);
                producto.Stock = reader.GetString(4);

                lista.Add(producto);
            }
            connection.Close();
            return lista;
        } 

        public static void Eliminar(int Id)
        {
            SqlConnection connection = BaseData.EstablecerConexion();
            string consulta = "deleteProductos";
            SqlCommand comando = new SqlCommand(consulta, connection);
            comando.CommandType = System.Data.CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@IDProducto", Id);
            comando.ExecuteNonQuery();
            connection.Close();

        }
    }
}
