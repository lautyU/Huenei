using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dominio
{
    public class Product
    {
        public int idProducto { get; set; }
        public string nombre { get; set; }
        public string descripcion { get; set; }
        public int precio { get; set; }
        public int stock { get; set; }

        public Product(int id, string nom, string desc, int pre, int st)
        {
            this.idProducto = id;
            this.nombre = nom;
            this.descripcion = desc;
            this.precio = pre;
            this.stock = st;
        }

        public Product() { }


    }
}