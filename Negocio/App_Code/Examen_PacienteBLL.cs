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
    }
}
