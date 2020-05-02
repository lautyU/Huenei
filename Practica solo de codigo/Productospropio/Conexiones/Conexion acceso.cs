using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Conexiones
{
    public class BdComun
    {

        public static SqlConnection ObtenerConexion()
        {
            SqlConnection conectar = new SqlConnection("DESKTOP-HRQA4RT;Initial Catalog=Taller;Integrated Security=true;");

            conectar.Open();
            return conectar;
        }
        
    }
}
