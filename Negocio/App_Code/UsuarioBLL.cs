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
        public static List<ModelUsuario> ListUsuarios()
        {
            return obj.ListUsuarios();
        }

        public static void Agregar(USUARIO usuario)
        {
            obj.Agregar(usuario);
        }

        public static USUARIO GetUsuario(int id)
        {
            return obj.getUsuario(id);
        }

        public static void Editar(USUARIO usuario)
        {
            obj.Editar(usuario);
        }
        public static void Eliminar(int id)
        {
            obj.Eliminar(id);
        }
    }
}
