using Entidad;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos.App_Code
{
    public class Paciente_HabitacionDAL
    {
        public List<PACIENTE_HABITACION> ListPaciHabi()
        {
            using (DBClinicaEntities db = new DBClinicaEntities())
            {
                return db.PACIENTE_HABITACION.ToList();
            }
        }
    }
}
