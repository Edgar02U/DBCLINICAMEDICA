using Datos.App_Code;
using Entidad;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio.App_Code
{
   public class MedicinaBLL
    {
        private static MedicinaDAL obj = new MedicinaDAL();
        public static List<MEDICINA> ListMedicina()
        {
            return obj.ListMedicina();
        }

    }
}
