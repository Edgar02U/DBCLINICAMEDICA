using Entidad;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos.App_Code
{
    public class ExamenDAL
    {
        public List<EXAMEN> ListExamen()
        {
            using (DBClinicaEntities db = new DBClinicaEntities())
            {
                return db.EXAMEN.ToList();
            }
        }
    }
}
