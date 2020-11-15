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
        public static void Agregar(HABITACION habitacion)
        {
            obj.Agregar(habitacion);
        }

        public static HABITACION GetHabitacion(int id)
        {
            return obj.getHabitacion(id);
        }

        public static void Editar(HABITACION habitacion)
        {
            obj.Editar(habitacion);
        }
        public static void Eliminar(int id)
        {
            obj.Eliminar(id);
        }

        public static List<ModelHabitacion> ListHabitaciones()
        {
            return obj.ListHabitaciones();
        }
    }
}
