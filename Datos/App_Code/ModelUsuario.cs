using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos.App_Code
{
    public class ModelUsuario
    {
        public int ID_USUARIO { get; set; }
        public string PRIMER_NOMBRE { get; set; }
        public string SEGUNDO_NOMBRE { get; set; }
        public string PRIMER_APELLIDO { get; set; }
        public string SEGUNDO_APELLIDO { get; set; }
        public string USERC { get; set; }
        public string PASSWORD { get; set; }
        public Nullable<int> EDAD { get; set; }
        public Nullable<System.DateTime> FECHA_CREACION { get; set; }
        public string ESTADO { get; set; }
        public string PUESTO { get; set; }
        public string GENERO { get; set; }
        public string SUCURSAL { get; set; }
    }
}


