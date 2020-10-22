using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos.App_Code
{
    public class ModelPaciente
    {

        public int ID_PACIENTE { get; set; }
        public string PRIMER_NOMBRE { get; set; }
        public string SEGUNDO_NOMBRE { get; set; }
        public string PRIMER_APELLIDO { get; set; }
        public string SEGUNDO_APELLIDO { get; set; }
        public Nullable<int> EDAD { get; set; }
        public string DIRECCION { get; set; }
        public Nullable<System.DateTime> FECHA_NACIMIENTO { get; set; }
        public Nullable<int> TELEFONO { get; set; }
        public string CORREO_ELECTRONICO { get; set; }
        public Nullable<int> ID_SUCURSAL { get; set; }
    }
}
