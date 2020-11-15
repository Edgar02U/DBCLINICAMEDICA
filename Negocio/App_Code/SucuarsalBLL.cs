using Datos.App_Code;
using Entidad;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio.App_Code
{
    public class SucuarsalBLL
    {
        private static SucursalDAL obj = new SucursalDAL();
        public static List<SUCURSAL> ListSucursal()
        {
            return obj.ListSucursal();
        }

        public static List<ModelSucursal> ListSucursales()
        {
            return obj.ListSucursales();
        }

        public static void Agregar(SUCURSAL sucursal)
        {
            obj.Agregar(sucursal);
        }

        public static SUCURSAL GetSucursal(int id)
        {
            return obj.getSucursal(id);
        }

        public static void Editar(SUCURSAL sucursal)
        {
            obj.Editar(sucursal);
        }
        public static void Eliminar(int id)
        {
            obj.Eliminar(id);
        }
    }
}
