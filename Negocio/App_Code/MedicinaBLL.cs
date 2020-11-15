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

        public static void Agregar(MEDICINA medicina)
        {
            obj.Agregar(medicina);
        }

        public static MEDICINA GetMedicina(int id)
        {
            return obj.getMedicina(id);
        }

        public static void Editar(MEDICINA medicina)
        {
            obj.Editar(medicina);
        }
        public static void Eliminar(int id)
        {
            obj.Eliminar(id);
        }

    }
}
