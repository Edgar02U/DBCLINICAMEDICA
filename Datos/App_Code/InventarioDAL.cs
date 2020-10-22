using Entidad;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos.App_Code
{
    public class InventarioDAL
    {
        public List<INVENTARIO> ListInventario()
        {

            using (DBClinicaEntities db = new DBClinicaEntities())
            {
                return db.INVENTARIO.ToList();

            }
        }
    }
}
