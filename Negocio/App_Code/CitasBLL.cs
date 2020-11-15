using Datos.App_Code;
using Entidad;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Negocio.App_Code
{
    public class CitasBLL
    {
        private static CitasDAL obj = new CitasDAL();

        public static void Agregar(CITAS cita)
        {
            obj.Agregar(cita);
        }

        public static CITAS GetCita(int id)
        {
            return obj.getCita(id);
        }

        public static void Editar(CITAS cita)
        {
            obj.Editar(cita);
        }
        public static void Eliminar(int id)
        {
            obj.Eliminar(id);
        }
        public static List<CITAS> ListCita()
        {
            return obj.ListCita();
        }   

        public static List<ModelCitas> List_Citas()
        {
            return obj.ListCitas();
        }
        
    }
}
