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

        public static List<CITAS> ListCita()
        {
            return obj.ListCita();
        }   
    }
}
