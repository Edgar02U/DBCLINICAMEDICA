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
    }
}
