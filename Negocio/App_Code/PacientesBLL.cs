using Datos.App_Code;
using Entidad;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio.App_Code
{
    public class PacientesBLL
    {
        private static PacientesDAL obj = new PacientesDAL();
        public static List<PACIENTE> ListPacientes()
        {
            return obj.ListPacientes();
        }
    }
}
