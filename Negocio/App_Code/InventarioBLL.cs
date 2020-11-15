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

        public static List<ModelInventario> ListInvetarios()
        {
            return obj.ListInventarios();
        }

        public static void Agregar(INVENTARIO inventario)
        {
            obj.Agregar(inventario);
        }

        public static INVENTARIO GetInventario(int id)
        {
            return obj.getInventario(id);
        }

        public static void Editar(INVENTARIO inventario)
        {
            obj.Editar(inventario);
        }
        public static void Eliminar(int id)
        {
            obj.Eliminar(id);
        }

        public static SUCURSAL GetSucursal(int id)
        {
            return obj.getSucursal(id);
        }
        public static MEDICINA GetMedicina(int id)
        {
            return obj.getMedicina(id);
        }
    }
}
