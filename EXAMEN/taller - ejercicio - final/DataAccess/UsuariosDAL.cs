using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using Taller.Domain;

namespace Taller.DataAccess
{
    public class UsuariosDAL
    {
        public static List<Usuario> Buscar()
        {
            List<Usuario> _lista = new List<Usuario>();
            SqlConnection conexion = BdComun.ObtenerConexion();

            SqlCommand _comando = new SqlCommand("GetUsuarios", conexion);
            _comando.CommandType = System.Data.CommandType.StoredProcedure;
            SqlDataReader _reader = _comando.ExecuteReader();
            while (_reader.Read())
            {
                Usuario usuario = new Usuario();
                usuario.User = _reader.GetString(0);
                usuario.Clave = _reader.GetString(1);
                usuario.NLogins = _reader.GetInt32(2);
                usuario.FechaLogin = _reader.GetString(3);
                
                _lista.Add(usuario);
            }

            conexion.Close();

            return _lista;
        }

        public static int Actualizar(Usuario usuario)
        {
            int retorno = 0;
            SqlConnection conexion = BdComun.ObtenerConexion();
            usuario.User = "pfernandez";
            SqlCommand comando = new SqlCommand("UpdateUsuario", conexion);
            comando.CommandType = System.Data.CommandType.StoredProcedure;
            comando.Parameters.Add(new SqlParameter("@usuario", usuario.User));

            retorno = comando.ExecuteNonQuery();
            conexion.Close();

            return retorno;

        }
       
    }
}
