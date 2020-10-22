using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos.App_Code
{
    public class ModelCitas
    {
        public int ID_CITA { get; set; }
        public System.DateTime FECHA { get; set; }
        public string OBOSERVACIONES { get; set; }
        public int ID_PACIENTE { get; set; }
    }
}
