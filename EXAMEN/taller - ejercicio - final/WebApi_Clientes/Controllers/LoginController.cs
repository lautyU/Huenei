using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Cors;
using Taller.BussinesLogic;
using Taller.Domain;

namespace WebAPIClientes
{
    public class LoginController : ApiController
    {
        public string Post([FromBody]Usuario usuario)
        {
            string result = "No implementado";

            List<Usuario> lista = UsuariosManager.Get().Where(a => usuario.User.Equals(a.User)).ToList();
            if (lista.Count != 0)
            {
                if (usuario.NLogins <= 3)
                {
                    if (lista[0].Clave.Equals(usuario.Clave))
                    {
                        result = "Autenticación realizada exitosamente.";
                    }
                    else
                    {
                        result = "Fallo en la autenticación. Intente nuevamente";
                        usuario.NLogins++;
                        UsuariosManager.Actualizar(usuario);
                    }
                }
                else
                {
                    result = "Usuario bloqueado.";
                }

            }
            else
            {
                result = "No se ha encontrado el usuario ingresado.";
            }



            return result;
        }



    }



}