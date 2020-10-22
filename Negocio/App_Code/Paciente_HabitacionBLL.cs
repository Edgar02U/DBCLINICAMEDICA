using Datos.App_Code;
using Entidad;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio.App_Code
{
    public class Paciente_HabitacionBLL
    {
        private static Paciente_HabitacionDAL obj = new Paciente_HabitacionDAL();
        
        public static List<PACIENTE_HABITACION> ListPaciHabi()
        {
            return obj.ListPaciHabi();
        }
    }
}
