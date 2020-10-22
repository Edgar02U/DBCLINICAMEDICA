using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos.App_Code
{
    public class ModelPaciente_Habitacion
    {
        public int ID_PACIENTE_HABITACION { get; set; }
        public int ID_PACIENTE { get; set; }
        public int ID_HABITACION { get; set; }
        public System.DateTime Fecha_Estancia { get; set; }

        //public virtual HABITACION HABITACION { get; set; }
        //public virtual PACIENTE PACIENTE { get; set; }
    }
}
