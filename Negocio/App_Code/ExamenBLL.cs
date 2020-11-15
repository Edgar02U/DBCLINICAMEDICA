using Datos.App_Code;
using Entidad;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio.App_Code
{
    public class ExamenBLL
    {
        public static List<EXAMEN> ListExamen()
        {
            return obj.ListExamen();
        }
        private static ExamenDAL obj = new ExamenDAL();
        public static List<ModelExamen> ListExamenes()
        {
            return obj.ListExamen_();
        }

        public static void Agregar(EXAMEN examen)
        {
            obj.Agregar(examen);
        }

        public static EXAMEN GetExamen(int id)
        {
            return obj.getExamen(id);
        }

        public static void Editar(EXAMEN examen)
        {
            obj.Editar(examen);
        }
        public static void Eliminar(int id)
        {
            obj.Eliminar(id);
        }
    }
}
