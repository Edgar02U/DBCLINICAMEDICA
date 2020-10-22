using Datos.App_Code;
using Entidad;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio.App_Code
{
    public class InventarioBLL
    {
        private static InventarioDAL obj = new InventarioDAL();

        public static List<INVENTARIO> ListInventario()
        {
            return obj.ListInventario();
        }
    }
}
