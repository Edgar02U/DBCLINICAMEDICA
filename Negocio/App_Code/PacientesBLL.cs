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
        public static void Agregar(PACIENTE paciente)
        {
            obj.Agregar(paciente);
        }
               
        public static PACIENTE GetPaciente(int id)
        {
            return obj.getPaciente(id);
        }

        public static void Editar(PACIENTE paciente)
        {
            obj.Editar(paciente);
        }
        public static void Eliminar(int id)
        {
             obj.Eliminar(id);
        }
        public static List<PACIENTE> ListPaciente()
        {
            return obj.ListPaciente();
        }

        public static List<ModelPaciente> ListPacientes()
        {
            return obj.ListPacientes();
        }

        public static SUCURSAL GetSucursal(int id)
        {
            return obj.getSucursal(id);
        }
    }
}
