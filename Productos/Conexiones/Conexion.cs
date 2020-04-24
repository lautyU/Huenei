using Producto;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Conexiones
{
    public class Conexion
    {
        SqlConnection conexion;
        SqlCommand comandos;
        Product producto;

        public Conexion()
        {
            string source = @"Data Source=GERNIROZ-PC\SQLEXPRESS; Initial Catalog=Taller; Integrated Security=true;";
            try
            {
                conexion = new SqlConnection(source);
                //Y que si se conecta, se conecte al principio de ejecutar la clase. Por eso
                // lo hice dentro del constructor
            }
            catch (Exception e)
            {
                MessageBox.Show("Error al conectar con base de datos.\n"+e.Message);
            }
        }

        public void ordenarDatos(List<Product> datos)
        {
            int j = datos.Count - 1;

            producto = new Product();

            for (int i = 0; i < datos.Count / 2; i++)
            {
                producto.idProducto = datos[i].idProducto;
                producto.nombre = datos[i].nombre;
                producto.descripcion = datos[i].descripcion;
                producto.precio = datos[i].precio;
                producto.stock = datos[i].stock; 

                datos[i].idProducto = datos[j].idProducto;
                datos[i].nombre = datos[j].nombre;
                datos[i].descripcion = datos[j].descripcion;
                datos[i].precio = datos[j].precio;
                datos[i].stock = datos[j].stock;

                datos[j].idProducto = producto.idProducto;
                datos[j].nombre = producto.nombre;
                datos[j].descripcion = producto.descripcion;
                datos[j].precio = producto.precio;
                datos[j].stock = producto.stock;

                j -= 1;

                producto= new Product();
            }
        }

        public void mostrarDatos(DataGridView dgv)
        {
            conexion.Open();
            List<Product> datos = new List<Product>();
            producto = new Product(); 
            string ConsultaSelectAll = "SELECT * FROM dbo.productos";
            try
            {
                comandos = new SqlCommand(ConsultaSelectAll, conexion);
                SqlDataReader lector = comandos.ExecuteReader();

                while (lector.Read())
                {
                    producto.idProducto = lector.GetInt32(0);
                    producto.nombre = lector.GetString(1);
                    producto.descripcion = lector.GetString(2);
                    producto.precio = lector.GetInt32(3);
                    producto.stock = lector.GetInt32(4);
                    datos.Add(producto);
                    producto = new Product();
                }
            }
            catch (Exception e) { MessageBox.Show("Hubo un problema al cargar el DGV. \n" + e.Message); }

            ordenarDatos(datos);

            dgv.DataSource = datos;
            conexion.Close();
        }
    
        public void insert(Product p)
        {
            conexion.Open();
            try
            {
                comandos = new SqlCommand(string.Format("insertProductos " +
                    $"{p.nombre},{p.descripcion},{p.precio},{p.stock}"), conexion);
                comandos.ExecuteNonQuery();
            } catch (Exception e) { MessageBox.Show("Hubo un error al insertar un nuevo producto.\n" + e.Message); }
            
            conexion.Close();
        }

        public void update(Product p)
        {
            conexion.Open();
            try
            {
                comandos = new SqlCommand(string.Format("updateProductos " +
                $"{p.idProducto},{p.nombre},{p.descripcion},{p.precio},{p.stock}"), conexion);
                comandos.ExecuteNonQuery();
            } catch (Exception e) { MessageBox.Show("Hubo un problema al modificar los datos.\n" + e.Message); }

            conexion.Close();
        }
    }
}
