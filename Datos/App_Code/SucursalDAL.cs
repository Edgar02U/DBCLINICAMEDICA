using Entidad;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos.App_Code
{
    public class SucursalDAL
    {
        public List<SUCURSAL> ListSucursal()
        {
            using (DBClinicaEntities db = new DBClinicaEntities())
            {
                return db.SUCURSAL.ToList();
            }
        }
    }
}
