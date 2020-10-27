using Entidad;
using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Data.Entity.ModelConfiguration.Configuration;
using System.Diagnostics.PerformanceData;
using System.Linq;
using System.Runtime.CompilerServices;
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

        List<ModelInventario> Inventario = new List<ModelInventario>();

        public List<ModelInventario> ListInventarios()
        {
            using (DBClinicaEntities db = new DBClinicaEntities())
            {
                Inventario = (from i in db.INVENTARIO
                                  join m in db.MEDICINA
                                  on i.ID_MEDICINA equals m.ID_MEDICINA
                                  join su in db.SUCURSAL
                                  on i.ID_SUCURSAL equals su.ID_SUCURSAL
                                  select new ModelInventario
                                  {
                                      ID_TIPO_INVENTARIO = i.ID_TIPO_INVENTARIO,
                                      MEDICINA = m.NOMBRE,
                                      CANTIDAD = i.CANTIDAD,
                                      SUCURSAL = su.NOMBRE
                                  }
                            ).ToList();
            }
            return Inventario;
        }
    }
}
