using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos.App_Code
{
    public class ModelSucursal
    {
        public int ID_SUCURSAL { get; set; }
        public string NOMBRE { get; set; }
        public string DIRECCION { get; set; }
        public Nullable<int> TELEFONO { get; set; }
    }
}
