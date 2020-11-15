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

        public static List<ModelPaciente_Habitacion> ListPaciHabis()
        {
            return obj.ListPaciHabis();
        }
        public static void Agregar(PACIENTE_HABITACION pacienteHabitacion)
        {
            obj.Agregar(pacienteHabitacion);
        }

        public static PACIENTE_HABITACION GetPaciHabit(int id)
        {
            return obj.getPacienteHabitacion(id);
        }

        public static void Editar(PACIENTE_HABITACION pacienteHabitacion)
        {
            obj.Editar(pacienteHabitacion);
        }
        public static void Eliminar(int id)
        {
            obj.Eliminar(id);
        }
    }
}
