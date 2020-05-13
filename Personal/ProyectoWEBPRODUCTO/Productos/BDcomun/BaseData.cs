using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;
using System.Text;

namespace BDcomun
{
         class BaseData 
    {
        public static SqlConnection EstablecerConexion()
        {
            SqlConnection connection = new SqlConnection("Data Soucer=\\DESKTOP-HRQA4RT;Initial Catalog=Taller;Integrated Security =true;");
            connection.Open();
            return connection;
        }        
        
    }
}
