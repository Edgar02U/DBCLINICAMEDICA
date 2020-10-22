using Entidad;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos.App_Code
{
    public class CitasDAL
    {
        public List<CITAS> ListCita()
        {
            
            using (DBClinicaEntities db = new DBClinicaEntities())
            {
                var obcita = new CitasDAL();
                return db.CITAS.ToList();
                
            }
        }
    }
}
