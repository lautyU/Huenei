using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Dominio;
using BDcomun;

namespace WindowsFormsApp1
{
    static class Verficadores
    {
        public static void Guardar(Producto producto)
        {
            if ((producto.Id).Equals(0))
            {
                if (!vacios(producto))
                {
                    datosproductos.Guardar(producto);
                    MessageBox.Show("Se añadio el prodcuto: " + producto.Nombre + " Con exito ");
                }
                else
                {
                    MessageBox.Show("Debe Completar los campos vacios!", "Cuidado");
                }
                
            }
            else
            {
                datosproductos.Modificar(producto);
                MessageBox.Show("El producto" + producto.Nombre + "Fue modificado correctamente");

            }
        }
        public static void Eliminar(int Id)
        {
            if (Id.Equals(0))
               {
                MessageBox.Show("Seleccione un producto de la lista , por favor", "Atencion");
            }
            else
            {
                if (MessageBox.Show("Quieres eliminar el producto?","Esta por eliminar un producto",MessageBoxButtons.YesNo)==DialogResult.Yes)
                {
                    datosproductos.Eliminar(Id);
                }       
             }
        }
        public static List<Producto> obtenerProducto()
        {
            return datosproductos.Obtener();
        }
        private static bool vacios(Producto producto)//verificador de campos vacio 
           //lo que hace aca es tomar un bollean , donde compara los campos de cada uno  en un 
           //largo if , donde dice , si nombre y descripcion , etc esta vacio envia  un true  sino envia un false
        {
            bool isempty = true;
            if (!(string.IsNullOrEmpty(producto.Nombre) && string.IsNullOrEmpty(producto.Descripcion) &&
                string.IsNullOrEmpty(producto.Precio) && string.IsNullOrEmpty(producto.Stock)))
            {
                isempty = false;
                return isempty;
            }
            return isempty;
         }
    }
}
