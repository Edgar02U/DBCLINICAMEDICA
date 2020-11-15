using Datos.App_Code;
using Entidad;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio.App_Code
{
    public class Examen_PacienteBLL
    {
        private static Examen_PacienteDAL obj = new Examen_PacienteDAL();
        public static List<EXAMEN_PACIENTE> ListExamenPaciente()
        {
            return obj.ListExamePaciente();
        }

        public static List<ModelExamen_Paciente> ListExPatient()
        {
            return obj.ListExamenesPacientes();
        }

        public static void Agregar(EXAMEN_PACIENTE examenPaciente)
        {
            obj.Agregar(examenPaciente);
        }

        public static EXAMEN_PACIENTE GetExamenPaciente(int id)
        {
            return obj.getExaPaci(id);
        }

        public static void Editar(EXAMEN_PACIENTE examenPaciente)
        {
            obj.Editar(examenPaciente);
        }
        public static void Eliminar(int id)
        {
            obj.Eliminar(id);
        }
    }
}
