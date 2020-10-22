using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos.App_Code
{
    public class ModelExamen_Paciente
    {
        public int ID_EXAMEN_PACIENTE { get; set; }
        public string NOMBRE_EXAMEN { get; set; }
        public string PACIENTE { get; set; }
        public System.DateTime FECHA_REALIZO { get; set; }
        public string ENCARGADO { get; set; }
    }
}
