using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Dominio;
using BDcomun;
using Newtonsoft;
namespace web_api.App_Start
{
    public class ProductosController : ApiController
    {
       public IEnumerable<Producto>Get()
        {
            return verificadores.obtenerProduct();

        }
        public void Post([FromBody]Producto producto)
        {
            ManejoProducto.Guardar(producto);
        }

        // PUT api/<controller>/5
        public void Put([FromBody]Producto producto)
        {
            ManejoProducto.Guardar(producto);
        }

        // DELETE api/<controller>/5
        public void Delete(int id)
        {
            ManejoProducto.Eliminar(id);
        }
    }
}
