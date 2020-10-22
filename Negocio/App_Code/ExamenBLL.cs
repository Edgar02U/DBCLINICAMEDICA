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
        private static ExamenDAL obj = new ExamenDAL();
        public static List<EXAMEN> ListExamen()
        {
            return obj.ListExamen();
        }
    }
}
