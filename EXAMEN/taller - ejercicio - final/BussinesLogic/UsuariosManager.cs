using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Taller.DataAccess;
using Taller.Domain;

namespace Taller.BussinesLogic
{
    public static class UsuariosManager
    {
        public static int Actualizar (Usuario usuario)
        {
            return UsuariosDAL.Actualizar(usuario);
        }

        public static List<Usuario> Get()
        {
            return UsuariosDAL.Buscar();
        }
    }
}
