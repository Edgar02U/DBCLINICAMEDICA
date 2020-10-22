using Datos.App_Code;
using Entidad;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio.App_Code
{
    public class HabitacionBLL
    {
        private static HabitacionDAL obj = new HabitacionDAL();
        public static List<HABITACION> ListHabitacion()
        {
            return obj.ListHabitacion();
        }
    }
}
