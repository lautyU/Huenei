using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dominio
{
    public class Producto
    {
        public int Id { get; set; }
        public string Nombre { get; set; }

        public string Descripcion { get; set; }
        public string Precio { get; set; }
        public String Stock { get; set; }
    
        public Producto() { }

        public Producto(int id, string nombre , string descripcion , string precio, string stock)
        {
            this.Id = id;
            this.Nombre = nombre;
            this.Descripcion = descripcion;
            this.Precio = precio;
            this.Stock = stock;
        }
    }
    
}
