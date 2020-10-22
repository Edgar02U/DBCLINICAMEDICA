using Datos.App_Code;
using Entidad;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio.App_Code
{
    public class UsuarioBLL
    {
        private static UsuarioDAL obj = new UsuarioDAL();
        public static List<USUARIO> ListUsuario()
        {
            return obj.ListUsuario();
        }
    }
}
